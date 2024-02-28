using System.Diagnostics;
namespace WordCount {
    public partial class Form1 : Form {

        String path = null;
        Dictionary<string, int> dictionaryFile = new Dictionary<string, int>();

        public Form1() {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog fileBrowserDialog = new OpenFileDialog();
            if (fileBrowserDialog.ShowDialog() == DialogResult.OK) {
                path = fileBrowserDialog.FileName;
                //MessageBox.Show(path);
                CountWord(path);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void CountWord(String path) {
            try {
                StreamReader streamReader = new StreamReader(path);
                string line = streamReader.ReadLine();
                while (line != null) {
                    line = streamReader.ReadLine();
                    string[] words;
                    words = line.Split(" ");
                    ConvertToDictionory(words);
                }
                streamReader.Close();
                Console.ReadLine();
            } catch(Exception ex) {
                return;                
            }
            
        }

        private void ConvertToDictionory(string[] words) { 
                    
        }
    }
}
