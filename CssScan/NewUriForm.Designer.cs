
namespace CssScan
{
    partial class NewUriForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UriBox = new System.Windows.Forms.TextBox();
            this.MaxDepth = new System.Windows.Forms.TextBox();
            this.RestrictDomain = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UriBox
            // 
            this.UriBox.Location = new System.Drawing.Point(124, 13);
            this.UriBox.Name = "UriBox";
            this.UriBox.Size = new System.Drawing.Size(242, 23);
            this.UriBox.TabIndex = 0;
            this.UriBox.TextChanged += new System.EventHandler(this.Uri_TextChanged);
            // 
            // MaxDepth
            // 
            this.MaxDepth.Location = new System.Drawing.Point(124, 67);
            this.MaxDepth.Name = "MaxDepth";
            this.MaxDepth.Size = new System.Drawing.Size(100, 23);
            this.MaxDepth.TabIndex = 1;
            this.MaxDepth.Text = "1";
            // 
            // RestrictDomain
            // 
            this.RestrictDomain.AutoSize = true;
            this.RestrictDomain.Location = new System.Drawing.Point(124, 42);
            this.RestrictDomain.Name = "RestrictDomain";
            this.RestrictDomain.Size = new System.Drawing.Size(109, 19);
            this.RestrictDomain.TabIndex = 2;
            this.RestrictDomain.Text = "Stay on domain";
            this.RestrictDomain.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "URI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Restrict domain";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Link levels to parse";
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(124, 97);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(118, 23);
            this.Ok.TabIndex = 6;
            this.Ok.Text = "&OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(248, 97);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(118, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "&Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // NewUriForm
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(376, 131);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RestrictDomain);
            this.Controls.Add(this.MaxDepth);
            this.Controls.Add(this.UriBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewUriForm";
            this.Text = "New Uri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UriBox;
        private System.Windows.Forms.TextBox MaxDepth;
        private System.Windows.Forms.CheckBox RestrictDomain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
    }
}