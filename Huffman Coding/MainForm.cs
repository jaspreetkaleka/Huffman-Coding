using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace HuffmanCoding
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Hashtable msgProbabilities;
        Hashtable msgCodewords;
        List<string> msgChars;
        int M;

        double Hx;
        double L̅;
        double η;
        double totalProbability;
        int minimumCodewordLength;
        int maximumCodewordLength;

        private void MainForm_Load(object sender, EventArgs e)
        {
            inputDataGridView.Rows.Clear();
        }

        private void encodeButton_Click(object sender, EventArgs e)
        {
            if (inputDataGridView.Rows.Count <= 2)
            {
                MessageBox.Show("Enter at least two messages.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            encodeButton.Enabled = false;
            encodeButton.Text = "Please Wait...";

            msgChars = new List<string>();
            List<string> msgProbs = new List<string>();

            foreach (DataGridViewRow row in inputDataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    msgChars.Add(row.Cells[0].Value.ToString());
                    msgProbs.Add(row.Cells[1].Value.ToString());
                }
            }

            M = (int)M_NumericUpDown.Value;

            Huffman.Encode(msgChars, msgProbs, M, out msgProbabilities, out msgCodewords, out totalProbability, out Hx, out L̅, out  η, out minimumCodewordLength, out maximumCodewordLength);

            encodeButton.Enabled = true;
            encodeButton.Text = ">> Encode >>";

            this.WindowState = FormWindowState.Minimized;
            ViewResultForm viewResult = new ViewResultForm(msgChars,msgProbabilities, msgCodewords, M, Hx, L̅, η, totalProbability, minimumCodewordLength, maximumCodewordLength);
            viewResult.Show();
            viewResult.WindowState = FormWindowState.Normal;
        }

        private void inputDataGridView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileDrop"))
            {
                string fileName = ((string[])e.Data.GetData("FileName"))[0].ToLower();
                if (fileName.EndsWith(".txt"))
                {
                    e.Effect = DragDropEffects.Copy;
                }
            }
            else if (e.Data.GetDataPresent("System.String[]"))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void inputDataGridView_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileDrop"))
            {
                try
                {
                    string[] data = File.ReadAllLines(((string[])e.Data.GetData("FileName"))[0]);
                    inputDataGridView.Rows.Clear();

                    foreach (string dataLine in data)
                    {
                        if (dataLine.StartsWith("NL"))
                        {
                            inputDataGridView.Rows.Add(new object[] { "NL", dataLine.Substring(2) });
                        }
                        else
                        {
                            inputDataGridView.Rows.Add(new object[] { dataLine[0], dataLine.Substring(1) });
                        }
                    }
                }
                catch { }
            }
            else if (e.Data.GetDataPresent("System.String[]"))
            {
                try
                {
                    string[] data = ((string[])e.Data.GetData("System.String[]"));
                    inputDataGridView.Rows.Clear();

                    foreach (string dataLine in data)
                    {
                        if (dataLine.StartsWith("NL"))
                        {
                            inputDataGridView.Rows.Add(new object[] { "NL", dataLine.Substring(2) });
                        }
                        else
                        {
                            inputDataGridView.Rows.Add(new object[] { dataLine[0], dataLine.Substring(1) });
                        }
                    }
                }
                catch { }
            }
        }

        private void loadFromButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files|*.txt";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] data = File.ReadAllLines(ofd.FileName);
                inputDataGridView.Rows.Clear();

                foreach (string dataLine in data)
                {
                    if (dataLine.StartsWith("NL"))
                    {
                        inputDataGridView.Rows.Add(new object[] { "NL", dataLine.Substring(2) });
                    }
                    else
                    {
                        inputDataGridView.Rows.Add(new object[] { dataLine[0], dataLine.Substring(1) });
                    }
                }
            }
        }
      
    }
}
