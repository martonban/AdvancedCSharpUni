namespace WinFormsApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            double inch = double.Parse(inputBox.Text);

            outputTextBox.Text = (inch * 0.0254).ToString();
        }
    }
}
