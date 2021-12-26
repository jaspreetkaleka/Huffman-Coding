using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HuffmanCoding
{
    public partial class DecodeForm : Form
    {
        public DecodeForm()
        {
            InitializeComponent();
        }

        Hashtable msgCodewords;
        List<string> msgChars;
        int M;

        public DecodeForm(Hashtable msgCodewords, IEnumerable<string> msgChars,int M)
        {
            InitializeComponent();

            this.msgCodewords = msgCodewords;

            this.msgChars = new List<string>();
            this.msgChars.AddRange(msgChars);

            this.M = M;
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            string inputSeq = inputSequenceRichTextBox.Text;

            List<string> encodedMsg = new List<string>();
            foreach (string ch in msgChars)
            {
                encodedMsg.Add(msgCodewords[ch].ToString().Replace(",", ""));
            }

            decodedSequenceRichTextBox.Clear();
            int startIndex = 0;
            bool toogleColor = true;
            while (inputSeq != "")
            {
                bool decoded = false;
                for (int i = 0; i < encodedMsg.Count; i++)
                {
                    if (inputSeq.StartsWith(encodedMsg[i]))
                    {
                        int index = decodedSequenceRichTextBox.Text.Length;
                        //string dataToAppend = inputDataGridView.Rows[i].Cells[0].Value.ToString();
                        string dataToAppend = msgChars[i];
                        if (dataToAppend == "NL")
                        {
                            decodedSequenceRichTextBox.AppendText(Environment.NewLine);
                        }
                        else
                        {
                            decodedSequenceRichTextBox.AppendText(dataToAppend);
                            decodedSequenceRichTextBox.Select(index, 1);
                            decodedSequenceRichTextBox.SelectionColor = toogleColor ? Color.Red : Color.Blue;
                        }

                        inputSeq = inputSeq.Substring(encodedMsg[i].Length);

                        inputSequenceRichTextBox.Select(startIndex, encodedMsg[i].Length);
                        inputSequenceRichTextBox.SelectionColor = toogleColor ? Color.Red : Color.Blue;
                        startIndex = startIndex + encodedMsg[i].Length;

                        toogleColor = !toogleColor;
                        decoded = true;

                        break;
                    }
                }

                if (!decoded)
                {
                    int index = decodedSequenceRichTextBox.Text.Length;
                    decodedSequenceRichTextBox.AppendText(inputSeq);

                    decodedSequenceRichTextBox.Select(index, inputSeq.Length);
                    decodedSequenceRichTextBox.SelectionColor = Color.Black;

                    break;
                }
            }
        }

        private void generateRandomSequencePictureBox_Click(object sender, EventArgs e)
        {
            IEnumerable<string> encodingAlphabets = Huffman.GetEncodingAlphabets(M);
            string randomSeq = "";
            Random r = new Random();
            for (int i = 0; i < 30; i++)
            {
                randomSeq = randomSeq + encodingAlphabets.ElementAt(r.Next(0, M));
            }
            inputSequenceRichTextBox.Text = randomSeq;
        }

        private void inputSequenceRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (inputSequenceRichTextBox.Text.Contains("\t"))
            {
                inputSequenceRichTextBox.Text = inputSequenceRichTextBox.Text.Replace("\t", "").Replace(" ", "");
            }
        }

       
    }
}
