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
                CountWord(path);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void CountWord(String path) {
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines) {
                string[] words = line.Split(" ");
                ConvertToDictionory(words);
            }
        }

        private void ConvertToDictionory(string[] words) {
            foreach (string word in words) {
                if (dictionaryFile.ContainsKey(word)) {
                    dictionaryFile[word] += 1;
                } else {
                    dictionaryFile.Add(word, 1);
                }
            }
            dataGridView1.DataSource = dictionaryFile.ToArray();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            dataGridView1.DataSource = dictionaryFile;
        }
    }
}
