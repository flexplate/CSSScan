using System.Windows.Forms;

namespace CssScan
{
    public static class Prompt
    {
        public static string ShowDialog(string promptText, string windowCaption, string defaultEntry = "", bool showCancelButton = true)
        {
            Form prompt = new Form()
            {
                Width = 412,
                Height = 124,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                Text = windowCaption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 6, Top = 6, Width=384, Text = promptText };
            TextBox textBox = new TextBox() { Left = 6, Top = 24, Width = 384, Text = defaultEntry };
            Button confirmButton = new Button() { Text = "Ok", Left = 185, Width = 100, Top = 52, DialogResult = DialogResult.OK };
            confirmButton.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmButton);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmButton;

            if (showCancelButton)
            {
                Button cancelButton = new Button() { Text = "Cancel", Left = 291, Width = 100, Top = 52, DialogResult = DialogResult.Cancel };
                cancelButton.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(cancelButton);
            }

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
