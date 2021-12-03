using CssScan.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CssScan
{
    public partial class NewUriForm : Form
    {
        public Scan Scan { get; set; }

        private Uri uri;

        public NewUriForm(string initialUri = "")
        {
            InitializeComponent();
            Scan = new Scan();
            UriBox.Text = initialUri;
        }

        private void Uri_TextChanged(object sender, EventArgs e)
        {
            if (Uri.TryCreate(UriBox.Text, UriKind.Absolute, out uri))
            {
                RestrictDomain.Text = string.Format("Stay on {0}", uri.Host);
            }
            else
            {
                RestrictDomain.Text = "Stay on domain";
            }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (Uri.TryCreate(UriBox.Text, UriKind.Absolute, out uri))
            {
                Scan.RootUri = UriBox.Text;
            }
            else
            {
                MessageBox.Show("You must enter a valid URI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int TempLevels;
            if (int.TryParse(MaxDepth.Text, out TempLevels) && TempLevels > 0)
            {
                Scan.LevelsToParse = TempLevels;
            }
            else
            {
                MessageBox.Show("Max depth must be a positive whole number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Scan.RestrictToDomain = RestrictDomain.Checked;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
