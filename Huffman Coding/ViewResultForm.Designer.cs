namespace HuffmanCoding
{
    partial class ViewResultForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewResultForm));
            this.finalResultDataGridView = new System.Windows.Forms.DataGridView();
            this.msgColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbabilityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.decodeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.M_TextBox = new System.Windows.Forms.TextBox();
            this.PxTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.efficiencyTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HxTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LBarTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finalResultDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // finalResultDataGridView
            // 
            this.finalResultDataGridView.AllowDrop = true;
            this.finalResultDataGridView.AllowUserToAddRows = false;
            this.finalResultDataGridView.AllowUserToDeleteRows = false;
            this.finalResultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.finalResultDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.finalResultDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.finalResultDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.finalResultDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.finalResultDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.finalResultDataGridView.ColumnHeadersHeight = 40;
            this.finalResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.finalResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.msgColumn,
            this.ProbabilityColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.finalResultDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.finalResultDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finalResultDataGridView.EnableHeadersVisualStyles = false;
            this.finalResultDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.finalResultDataGridView.Location = new System.Drawing.Point(0, 150);
            this.finalResultDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.finalResultDataGridView.Name = "finalResultDataGridView";
            this.finalResultDataGridView.ReadOnly = true;
            this.finalResultDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.finalResultDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.finalResultDataGridView.RowTemplate.Height = 30;
            this.finalResultDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.finalResultDataGridView.Size = new System.Drawing.Size(751, 369);
            this.finalResultDataGridView.TabIndex = 0;
            // 
            // msgColumn
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.msgColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.msgColumn.Frozen = true;
            this.msgColumn.HeaderText = "Message [X]";
            this.msgColumn.Name = "msgColumn";
            this.msgColumn.ReadOnly = true;
            this.msgColumn.Width = 123;
            // 
            // ProbabilityColumn
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.ProbabilityColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProbabilityColumn.Frozen = true;
            this.ProbabilityColumn.HeaderText = "Probability [P]";
            this.ProbabilityColumn.Name = "ProbabilityColumn";
            this.ProbabilityColumn.ReadOnly = true;
            this.ProbabilityColumn.Width = 141;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.decodeButton);
            this.panel1.Controls.Add(this.titleLabel);
            this.panel1.Controls.Add(this.M_TextBox);
            this.panel1.Controls.Add(this.PxTextBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.efficiencyTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.HxTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LBarTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.DarkViolet;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 150);
            this.panel1.TabIndex = 10;
            // 
            // decodeButton
            // 
            this.decodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decodeButton.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.decodeButton.Location = new System.Drawing.Point(544, 118);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(72, 27);
            this.decodeButton.TabIndex = 5;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Crimson;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(751, 40);
            this.titleLabel.TabIndex = 32;
            this.titleLabel.Text = "Huffman Coding";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // M_TextBox
            // 
            this.M_TextBox.BackColor = System.Drawing.Color.White;
            this.M_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.M_TextBox.ForeColor = System.Drawing.Color.Red;
            this.M_TextBox.Location = new System.Drawing.Point(485, 57);
            this.M_TextBox.Name = "M_TextBox";
            this.M_TextBox.ReadOnly = true;
            this.M_TextBox.Size = new System.Drawing.Size(191, 23);
            this.M_TextBox.TabIndex = 3;
            this.M_TextBox.Text = "-";
            this.M_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PxTextBox
            // 
            this.PxTextBox.BackColor = System.Drawing.Color.White;
            this.PxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PxTextBox.ForeColor = System.Drawing.Color.Red;
            this.PxTextBox.Location = new System.Drawing.Point(485, 87);
            this.PxTextBox.Name = "PxTextBox";
            this.PxTextBox.ReadOnly = true;
            this.PxTextBox.Size = new System.Drawing.Size(191, 23);
            this.PxTextBox.TabIndex = 4;
            this.PxTextBox.Text = "-";
            this.PxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(421, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 23);
            this.label10.TabIndex = 30;
            this.label10.Text = "∑ [P] = ";
            // 
            // efficiencyTextBox
            // 
            this.efficiencyTextBox.BackColor = System.Drawing.Color.White;
            this.efficiencyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.efficiencyTextBox.ForeColor = System.Drawing.Color.Red;
            this.efficiencyTextBox.Location = new System.Drawing.Point(170, 117);
            this.efficiencyTextBox.Name = "efficiencyTextBox";
            this.efficiencyTextBox.ReadOnly = true;
            this.efficiencyTextBox.Size = new System.Drawing.Size(191, 23);
            this.efficiencyTextBox.TabIndex = 2;
            this.efficiencyTextBox.Text = "-";
            this.efficiencyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Efficiency, η (%) = ";
            // 
            // HxTextBox
            // 
            this.HxTextBox.BackColor = System.Drawing.Color.White;
            this.HxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HxTextBox.ForeColor = System.Drawing.Color.Red;
            this.HxTextBox.Location = new System.Drawing.Point(170, 87);
            this.HxTextBox.Name = "HxTextBox";
            this.HxTextBox.ReadOnly = true;
            this.HxTextBox.Size = new System.Drawing.Size(191, 23);
            this.HxTextBox.TabIndex = 1;
            this.HxTextBox.Text = "-";
            this.HxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "H[X] (bits/msg) = ";
            // 
            // LBarTextBox
            // 
            this.LBarTextBox.BackColor = System.Drawing.Color.White;
            this.LBarTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBarTextBox.ForeColor = System.Drawing.Color.Red;
            this.LBarTextBox.Location = new System.Drawing.Point(170, 57);
            this.LBarTextBox.Name = "LBarTextBox";
            this.LBarTextBox.ReadOnly = true;
            this.LBarTextBox.Size = new System.Drawing.Size(191, 23);
            this.LBarTextBox.TabIndex = 0;
            this.LBarTextBox.Text = "-";
            this.LBarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ḹ (letters/msg) = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "M = ";
            // 
            // ViewResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(751, 519);
            this.Controls.Add(this.finalResultDataGridView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ViewResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Huffman Coding";
            ((System.ComponentModel.ISupportInitialize)(this.finalResultDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView finalResultDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PxTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox efficiencyTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HxTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LBarTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox M_TextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn msgColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbabilityColumn;
        private System.Windows.Forms.Button decodeButton;
    }
}