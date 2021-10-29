using ExCSS;
using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace CssScan
{
    public partial class MainWindow : Form
    {
        #region Properties

        /// <summary>
        /// </summary>
        /// This collection stores the documents when they've been loaded. The string part of the key-value pair is the filename.
        public List<KeyValuePair<string, HtmlAgilityPack.HtmlDocument>> Pages { get; set; }

        #endregion Properties

        #region Constructors

        public MainWindow()
        {
            InitializeComponent();

            WebRequest.DefaultWebProxy.Credentials = CredentialCache.DefaultNetworkCredentials;

            PageList.SelectedIndexChanged += PageList_SelectedIndexChanged;
            Start.Click += Start_Click;
            AddFile.Click += AddFile_Click;
            AddURI.Click += AddUri_Click;
            RemovePage.Click += RemovePage_Click;
            Clear.Click += Clear_Click;

            Pages = new List<KeyValuePair<string, HtmlAgilityPack.HtmlDocument>>();
        }

        #endregion Constructors

        #region Enums

        /// <summary>
        /// This enum matches the indices of the icons in the Style State Images collection, used to provide a state image for each record in the style treeview.
        /// </summary>
        public enum StateIcon
        {
            Cross = 0,
            Tick = 1,
            Half = 2,
            Error = 3
        }

        #endregion Enums

        #region Methods

        /// <summary>
        /// Test a string to see if it contains a valid HTTP or HTTPS address.
        /// </summary>
        /// <param name="path">Path to test.</param>
        private static bool IsValidWebUri(string path)
        {
            Uri uriResult;
            return Uri.TryCreate(path, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        /// <summary>
        /// User wants to add a local file to the list.
        /// </summary>
        private void AddFile_Click(object sender, EventArgs e)
        {
            var OFD = new OpenFileDialog();
            OFD.Title = "Add File";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                PageList.Items.AddRange(OFD.FileNames);
            }
        }

        /// <summary>
        /// User wants to add a page by its URI.
        /// </summary>
        private void AddUri_Click(object sender, EventArgs e)
        {
            string DefaultUri = IsValidWebUri(Clipboard.GetText()) ? Clipboard.GetText() : null;
            string UserEntered = Prompt.ShowDialog("Enter the URI to add to the list", "Add URI", DefaultUri);
            if (!string.IsNullOrWhiteSpace(UserEntered))
            {
                PageList.Items.Add(UserEntered);
            }
        }

        /// <summary>
        /// User has clicked the button to reset the results window.
        /// </summary>
        private void Clear_Click(object sender, EventArgs e)
        {
            Pages.Clear();
            StyleList.Nodes.Clear();
        }

        /// <summary>
        /// Parse each file in the pages collection, get its stylesheets, test to see if they're used.
        /// </summary>
        private void GetStyles()
        {
            var Parser = new StylesheetParser();
            for (int PageIndex = 0; PageIndex < Pages.Count; PageIndex++)
            {
                SetStatus("Getting stylesheets in page {0} of {1}.", PageIndex + 1, Pages.Count);
                var item = Pages[PageIndex];
                var PageNode = new TreeNode(item.Key);

                // Get all stylesheets referenced externally to the document(<link rel="stylesheet" href="foo">).
                var Links = item.Value.DocumentNode.Descendants("link").Where(l => l.GetAttributeValue("rel", "") == "stylesheet").ToList();
                if (Links.Count == 0) { PageNode.Nodes.Add("No stylesheets."); }

                // Iterate over the stylesheets.
                for (int LinkIndex = 0; LinkIndex < Links.Count; LinkIndex++)
                {
                    SetStatus("Parsing Stylesheets: Page {0}/{1}, stylesheet {2}/{3}.", PageIndex + 1, Pages.Count, LinkIndex + 1, Links.Count);
                    HtmlNode link = Links[LinkIndex];

                    // Define somewhere for our CSS to go:
                    string Css = "";

                    using (var Client = new HttpClient())
                    {
                        // First we've got to actually get the CSS file.
                        // Can't get a stream without a full URI.
                        var requestUri = Flurl.Url.Combine(item.Key, link.GetAttributeValue("href", ""));

                        try
                        {
                            // Get the CSS file from the link. This normally runs asynchronously but we're waiting for it to do its thing.
                            var stream = Client.GetStreamAsync(requestUri).GetAwaiter().GetResult();
                            var Reader = new StreamReader(stream);
                            Css = Reader.ReadToEnd();
                        }
                        catch (HttpRequestException ex)
                        {
                            PageNode.StateImageIndex = (int)StateIcon.Error;
                            PageNode.ToolTipText = "Error";
                            PageNode.Nodes.Add(ex.Message);
                        }
                    }

                    // Read styles into treeview.
                    var Stylesheet = Parser.Parse(Css);
                    if (Stylesheet != null)
                    {
                        var SheetNode = new TreeNode(link.GetAttributeValue("href", "File"));
                        int UsedStyleCount = 0;

                        // Iterate over selectors in the stylesheet, see if they're used in the page they're linked from.
                        var Rules = Stylesheet.StyleRules.ToList();
                        for (int RuleIndex = 0; RuleIndex < Rules.Count; RuleIndex++)
                        {
                            SetStatus("Parsing Stylesheets: Page {0}/{1}, stylesheet {2}/{3}, rule {4}/{5}.", PageIndex + 1, Pages.Count, LinkIndex + 1, Links.Count, RuleIndex, Rules.Count);
                            IStyleRule Style = Rules[RuleIndex];
                            StateIcon StyleState = StateIcon.Cross;
                            string Usage = "Unused";
                            try
                            {
                                // If the selector appears in the document, we mark it as used.
                                int TimesSelectorUsed = item.Value.DocumentNode.QuerySelectorAll(Style.SelectorText).Count();
                                if (TimesSelectorUsed > 0)
                                {
                                    StyleState = StateIcon.Tick;
                                    Usage = string.Format("Used {0} time{1}.", TimesSelectorUsed, TimesSelectorUsed > 1 ? "s" : "");
                                    UsedStyleCount++;
                                }
                            }
                            catch (FormatException ex)
                            {
                                // Fizzler can't read everything. Show an error icon.
                                StyleState = StateIcon.Error;
                                Usage = ex.Message;
                            }
                            finally
                            {
                                TreeNode SelectorNode = new TreeNode(Style.SelectorText) { StateImageIndex = (int)StyleState };
                                SelectorNode.ToolTipText = Usage;
                                SheetNode.Nodes.Add(SelectorNode);
                            }
                        }

                        // Pick an icon for the sheet based on how many, if any, of the selectors in its stylesheets are used.
                        if (UsedStyleCount == 0)
                        {
                            // None are used.
                            SheetNode.StateImageIndex = (int)StateIcon.Cross;
                            SheetNode.ToolTipText = "Unused";
                        }
                        else if (UsedStyleCount < Stylesheet.StyleRules.Count())
                        {
                            // Some are used.
                            SheetNode.StateImageIndex = (int)StateIcon.Half;
                            SheetNode.ToolTipText = string.Format("{0} of {1} selectors used.", UsedStyleCount, Rules.Count);
                        }
                        else if (UsedStyleCount == Stylesheet.StyleRules.Count())
                        {
                            // All are used.
                            SheetNode.StateImageIndex = (int)StateIcon.Tick;
                            SheetNode.ToolTipText = string.Format("{0} of {1} selectors used.", UsedStyleCount, Rules.Count);
                        }
                        PageNode.Nodes.Add(SheetNode);
                    }
                }

                StyleList.Nodes.Add(PageNode);
            }
        }


        /// <summary>
        /// User has selected (or deselected) an item in the list of pages to scan. Set the "remove" button's ability accordingly.
        /// </summary>
        private void PageList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemovePage.Enabled = PageList.SelectedItem != null;
        }

        /// <summary>
        /// Parse our list of pages into the collection of HtmlDocuments.
        /// </summary>
        private void ReadHtmlFiles()
        {
            // The PageList control has a list of paths, both local and remote. Iterate over it.
            for (int i = 0; i < PageList.Items.Count; i++)
            {
                object item = PageList.Items[i];
                SetStatus("Loading page {0} of {1}.", i + 1, PageList.Items.Count);
                string path = item.ToString();

                var doc = new HtmlAgilityPack.HtmlDocument();
                if (File.Exists(path))
                {
                    // It's a local file. Load it.
                    doc.Load(path);
                }
                else if (IsValidWebUri(path))
                {
                    // It's not a local file, but its path is a valid web address. Download it then load it into the doc.
                    var web = new HtmlWeb();
                    doc = web.Load(path);
                }

                if (doc != default)
                {
                    // We parsed something. put it in the collection.
                    Pages.Add(new KeyValuePair<string, HtmlAgilityPack.HtmlDocument>(item.ToString(), doc));
                }
                else
                {
                    MessageBox.Show(string.Format("Could not open \"{0}\", it is not a path to a local file or a valid HTTP or HTTPS address.", path), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// User has clicked to remove the selected page from the list.
        /// </summary>
        private void RemovePage_Click(object sender, EventArgs e)
        {
            if (PageList.SelectedItem != null)
            {
                PageList.Items.RemoveAt(PageList.SelectedIndex);
            }
        }
        /// <summary>
        /// Set the status bar text.
        /// </summary>
        /// <param name="text">Text to display as a composite format string.</param>
        /// <param name="args">Array of objects to format into <paramref name="args"/>.</param>
        private void SetStatus(string text, params object[] args)
        {
            StatusDisplay.Text = string.Format(text, args);
        }

        ///<summary>
        /// User wants to start scanning.
        /// </summary>
        private void Start_Click(object sender, EventArgs e)
        {
            ReadHtmlFiles();
            GetStyles();
            SetStatus("Done.");
        }

        #endregion Methods
    }
}