namespace HuffmanCoding
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.inputDataGridView = new System.Windows.Forms.DataGridView();
            this.msgColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProbabilityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleLabel = new System.Windows.Forms.Label();
            this.M_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.encodeButton = new System.Windows.Forms.Button();
            this.loadFromButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // inputDataGridView
            // 
            this.inputDataGridView.AllowDrop = true;
            this.inputDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.inputDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inputDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.inputDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inputDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.inputDataGridView.ColumnHeadersHeight = 40;
            this.inputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.inputDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.msgColumn,
            this.ProbabilityColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inputDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.inputDataGridView.EnableHeadersVisualStyles = false;
            this.inputDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inputDataGridView.Location = new System.Drawing.Point(14, 104);
            this.inputDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.inputDataGridView.Name = "inputDataGridView";
            this.inputDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inputDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.inputDataGridView.RowTemplate.Height = 30;
            this.inputDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.inputDataGridView.Size = new System.Drawing.Size(294, 313);
            this.inputDataGridView.TabIndex = 2;
            this.inputDataGridView.DragDrop += new System.Windows.Forms.DragEventHandler(this.inputDataGridView_DragDrop);
            this.inputDataGridView.DragEnter += new System.Windows.Forms.DragEventHandler(this.inputDataGridView_DragEnter);
            // 
            // msgColumn
            // 
            this.msgColumn.HeaderText = "Message [X]";
            this.msgColumn.Name = "msgColumn";
            this.msgColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.msgColumn.Width = 104;
            // 
            // ProbabilityColumn
            // 
            this.ProbabilityColumn.HeaderText = "Probability [P]";
            this.ProbabilityColumn.Name = "ProbabilityColumn";
            this.ProbabilityColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProbabilityColumn.Width = 122;
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.DarkViolet;
            this.titleLabel.Location = new System.Drawing.Point(43, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(233, 40);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "Huffman Coding";
            // 
            // M_NumericUpDown
            // 
            this.M_NumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.M_NumericUpDown.ForeColor = System.Drawing.Color.Red;
            this.M_NumericUpDown.Location = new System.Drawing.Point(56, 62);
            this.M_NumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.M_NumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.M_NumericUpDown.Name = "M_NumericUpDown";
            this.M_NumericUpDown.Size = new System.Drawing.Size(101, 26);
            this.M_NumericUpDown.TabIndex = 0;
            this.M_NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.M_NumericUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.M_NumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "M = ";
            // 
            // encodeButton
            // 
            this.encodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encodeButton.Location = new System.Drawing.Point(163, 59);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(119, 33);
            this.encodeButton.TabIndex = 3;
            this.encodeButton.Text = "Encode";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // loadFromButton
            // 
            this.loadFromButton.BackgroundImage = global::HuffmanCoding.Properties.Resources.Add;
            this.loadFromButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loadFromButton.FlatAppearance.BorderSize = 0;
            this.loadFromButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadFromButton.Location = new System.Drawing.Point(14, 104);
            this.loadFromButton.Name = "loadFromButton";
            this.loadFromButton.Size = new System.Drawing.Size(40, 39);
            this.loadFromButton.TabIndex = 1;
            this.loadFromButton.UseVisualStyleBackColor = true;
            this.loadFromButton.Click += new System.EventHandler(this.loadFromButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 437);
            this.Controls.Add(this.loadFromButton);
            this.Controls.Add(this.M_NumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.inputDataGridView);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkViolet;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Huffman Coding";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView inputDataGridView;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn msgColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProbabilityColumn;
        private System.Windows.Forms.NumericUpDown M_NumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.Button loadFromButton;
    }
}

