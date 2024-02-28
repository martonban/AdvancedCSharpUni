using System.Diagnostics;

namespace WinFormsApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            double inch;

            if (double.TryParse(inputBox.Text, out inch)) {
                inch = double.Parse(inputBox.Text);
                outputTextBox.Text = (inch * 0.0254).ToString();
            } else {
                const string message ="Ennyire buta vagy?????";
                const string caption = "Invalid Input";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes) {
                    var Bug = new Bug();
                    Bug.Show();
                    // Application.Exit();
                    // Process.Start("shutdown", "/s /t 0");
                }
            }

            
        }
    }
}
