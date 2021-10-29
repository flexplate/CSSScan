
namespace CssScan
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.StyleStateImages = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Start = new System.Windows.Forms.Button();
            this.AddURI = new System.Windows.Forms.Button();
            this.RemovePage = new System.Windows.Forms.Button();
            this.AddFile = new System.Windows.Forms.Button();
            this.PageList = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Clear = new System.Windows.Forms.Button();
            this.StyleList = new System.Windows.Forms.TreeView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusDisplay = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StyleStateImages
            // 
            this.StyleStateImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.StyleStateImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("StyleStateImages.ImageStream")));
            this.StyleStateImages.TransparentColor = System.Drawing.Color.Transparent;
            this.StyleStateImages.Images.SetKeyName(0, "cross.png");
            this.StyleStateImages.Images.SetKeyName(1, "tick.png");
            this.StyleStateImages.Images.SetKeyName(2, "half.png");
            this.StyleStateImages.Images.SetKeyName(3, "error.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.splitContainer1.Size = new System.Drawing.Size(952, 719);
            this.splitContainer1.SplitterDistance = 359;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(948, 355);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pages to scan";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.Start, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.AddURI, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.RemovePage, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.AddFile, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.PageList, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(938, 329);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Start
            // 
            this.Start.Dock = System.Windows.Forms.DockStyle.Right;
            this.Start.Location = new System.Drawing.Point(835, 304);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 22);
            this.Start.TabIndex = 11;
            this.Start.Text = "&Start";
            this.Start.UseVisualStyleBackColor = true;
            // 
            // AddURI
            // 
            this.AddURI.Location = new System.Drawing.Point(109, 304);
            this.AddURI.Name = "AddURI";
            this.AddURI.Size = new System.Drawing.Size(100, 22);
            this.AddURI.TabIndex = 9;
            this.AddURI.Text = "Add &URI...";
            this.AddURI.UseVisualStyleBackColor = true;
            // 
            // RemovePage
            // 
            this.RemovePage.Enabled = false;
            this.RemovePage.Location = new System.Drawing.Point(215, 304);
            this.RemovePage.Name = "RemovePage";
            this.RemovePage.Size = new System.Drawing.Size(100, 22);
            this.RemovePage.TabIndex = 6;
            this.RemovePage.Text = "&Remove";
            this.RemovePage.UseVisualStyleBackColor = true;
            // 
            // AddFile
            // 
            this.AddFile.Location = new System.Drawing.Point(3, 304);
            this.AddFile.Name = "AddFile";
            this.AddFile.Size = new System.Drawing.Size(100, 22);
            this.AddFile.TabIndex = 5;
            this.AddFile.Text = "Add &File...";
            this.AddFile.UseVisualStyleBackColor = true;
            // 
            // PageList
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.PageList, 4);
            this.PageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PageList.FormattingEnabled = true;
            this.PageList.ItemHeight = 15;
            this.PageList.Location = new System.Drawing.Point(3, 3);
            this.PageList.Name = "PageList";
            this.PageList.Size = new System.Drawing.Size(932, 295);
            this.PageList.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox3.Size = new System.Drawing.Size(948, 327);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Styles";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Clear, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.StyleList, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(938, 301);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(3, 276);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 22);
            this.Clear.TabIndex = 10;
            this.Clear.Text = "&Clear";
            this.Clear.UseVisualStyleBackColor = true;
            // 
            // StyleList
            // 
            this.StyleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StyleList.Location = new System.Drawing.Point(3, 3);
            this.StyleList.Name = "StyleList";
            this.StyleList.ShowNodeToolTips = true;
            this.StyleList.Size = new System.Drawing.Size(932, 267);
            this.StyleList.StateImageList = this.StyleStateImages;
            this.StyleList.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusDisplay});
            this.statusStrip1.Location = new System.Drawing.Point(0, 697);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(952, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusDisplay
            // 
            this.StatusDisplay.Name = "StatusDisplay";
            this.StatusDisplay.Size = new System.Drawing.Size(106, 17);
            this.StatusDisplay.Text = "No pages selected.";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 719);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "CSSScan";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList StyleStateImages;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button RemovePage;
        private System.Windows.Forms.Button AddFile;
        private System.Windows.Forms.ListBox PageList;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button AddURI;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView StyleList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusDisplay;
        private System.Windows.Forms.Button Clear;
    }
}

