using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HuffmanCoding
{
    public partial class ViewResultForm : Form
    {
        public ViewResultForm()
        {
            InitializeComponent();
        }
        
        Hashtable msgCodewords;
        List<string> msgChars;
        int M;

        public ViewResultForm(IEnumerable<string> msgChars,Hashtable msgProbabilities, Hashtable msgCodewords, int M, double Hx, double L̅, double η, double totalProbability, int minimumCodewordLength, int maximumCodewordLength)
        {
            InitializeComponent();

            M_TextBox.Text = M.ToString();
            PxTextBox.Text = totalProbability.ToString();
            LBarTextBox.Text = L̅.ToString();
            HxTextBox.Text = Hx.ToString();
            efficiencyTextBox.Text = η.ToString();
            this.msgChars = new List<string>();
            this.msgChars.AddRange(msgChars);
            this.msgCodewords = msgCodewords;
            this.M = M;

            #region "Add required Columns."

            for (int i = 0; i < maximumCodewordLength; i++)
            {
                finalResultDataGridView.Columns.Add("col" + i, " ");
            }

            DataGridViewTextBoxColumn lengthCol = new DataGridViewTextBoxColumn();
            lengthCol.HeaderText = "Length";
            lengthCol.DefaultCellStyle = new DataGridViewCellStyle();
            lengthCol.DefaultCellStyle.ForeColor = Color.Red;
            lengthCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            finalResultDataGridView.Columns.Add(lengthCol);

            #endregion

            #region "Add required Rows"

            List<string> data;

            IDictionaryEnumerator en = msgProbabilities.GetEnumerator();

            while (en.MoveNext())
            {
                data = new List<string>();
                data.Add(en.Key.ToString());
                data.Add(en.Value.ToString());
                data.AddRange(msgCodewords[en.Key].ToString().Split(','));
                finalResultDataGridView.Rows.Add(data.ToArray());
                finalResultDataGridView.Rows[finalResultDataGridView.Rows.Count - 1].Cells[maximumCodewordLength + 2].Value = (data.Count - 2).ToString(); 
            }

            #endregion
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            DecodeForm dcForm = new DecodeForm(msgCodewords,msgChars,M);
            dcForm.Show();
        }
    }
}
