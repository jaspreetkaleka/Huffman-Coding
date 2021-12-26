namespace HuffmanCoding
{
    partial class DecodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecodeForm));
            this.generateRandomSequencePictureBox = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.decodedSequenceRichTextBox = new System.Windows.Forms.RichTextBox();
            this.inputSequenceRichTextBox = new System.Windows.Forms.RichTextBox();
            this.decodeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.generateRandomSequencePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // generateRandomSequencePictureBox
            // 
            this.generateRandomSequencePictureBox.Image = global::HuffmanCoding.Properties.Resources.spinner_grey;
            this.generateRandomSequencePictureBox.Location = new System.Drawing.Point(24, 86);
            this.generateRandomSequencePictureBox.Name = "generateRandomSequencePictureBox";
            this.generateRandomSequencePictureBox.Size = new System.Drawing.Size(16, 16);
            this.generateRandomSequencePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.generateRandomSequencePictureBox.TabIndex = 25;
            this.generateRandomSequencePictureBox.TabStop = false;
            this.generateRandomSequencePictureBox.Click += new System.EventHandler(this.generateRandomSequencePictureBox_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.DarkViolet;
            this.label12.Location = new System.Drawing.Point(22, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 23);
            this.label12.TabIndex = 24;
            this.label12.Text = "Decoded Sequence :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.DarkViolet;
            this.label11.Location = new System.Drawing.Point(43, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 23);
            this.label11.TabIndex = 23;
            this.label11.Text = "Input Sequence :";
            // 
            // decodedSequenceRichTextBox
            // 
            this.decodedSequenceRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decodedSequenceRichTextBox.BackColor = System.Drawing.Color.White;
            this.decodedSequenceRichTextBox.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodedSequenceRichTextBox.Location = new System.Drawing.Point(185, 121);
            this.decodedSequenceRichTextBox.Name = "decodedSequenceRichTextBox";
            this.decodedSequenceRichTextBox.ReadOnly = true;
            this.decodedSequenceRichTextBox.Size = new System.Drawing.Size(527, 116);
            this.decodedSequenceRichTextBox.TabIndex = 2;
            this.decodedSequenceRichTextBox.Text = "";
            // 
            // inputSequenceRichTextBox
            // 
            this.inputSequenceRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputSequenceRichTextBox.Location = new System.Drawing.Point(185, 73);
            this.inputSequenceRichTextBox.Multiline = false;
            this.inputSequenceRichTextBox.Name = "inputSequenceRichTextBox";
            this.inputSequenceRichTextBox.Size = new System.Drawing.Size(527, 42);
            this.inputSequenceRichTextBox.TabIndex = 0;
            this.inputSequenceRichTextBox.Text = "";
            this.inputSequenceRichTextBox.ZoomFactor = 1.5F;
            this.inputSequenceRichTextBox.TextChanged += new System.EventHandler(this.inputSequenceRichTextBox_TextChanged);
            // 
            // decodeButton
            // 
            this.decodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decodeButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodeButton.ForeColor = System.Drawing.Color.DarkViolet;
            this.decodeButton.Location = new System.Drawing.Point(29, 175);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(141, 62);
            this.decodeButton.TabIndex = 1;
            this.decodeButton.Text = ">> Decode >>";
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
            this.titleLabel.Size = new System.Drawing.Size(731, 40);
            this.titleLabel.TabIndex = 33;
            this.titleLabel.Text = "Huffman Decoding";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DecodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 252);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.generateRandomSequencePictureBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.decodedSequenceRichTextBox);
            this.Controls.Add(this.inputSequenceRichTextBox);
            this.Controls.Add(this.decodeButton);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DecodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Huffman Decoding";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.generateRandomSequencePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox generateRandomSequencePictureBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox decodedSequenceRichTextBox;
        private System.Windows.Forms.RichTextBox inputSequenceRichTextBox;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.Label titleLabel;

    }
}