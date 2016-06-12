namespace RodHall.CTMWordCounter.App {
    partial class WordCounter {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnCountWords = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvWords = new System.Windows.Forms.DataGridView();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPrime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCountWords
            // 
            this.btnCountWords.Location = new System.Drawing.Point(12, 12);
            this.btnCountWords.Name = "btnCountWords";
            this.btnCountWords.Size = new System.Drawing.Size(111, 36);
            this.btnCountWords.TabIndex = 0;
            this.btnCountWords.Text = "Count Words";
            this.btnCountWords.UseVisualStyleBackColor = true;
            this.btnCountWords.Click += new System.EventHandler(this.btnCountWords_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(142, 35);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 1;
            // 
            // dgvWords
            // 
            this.dgvWords.AllowUserToAddRows = false;
            this.dgvWords.AllowUserToDeleteRows = false;
            this.dgvWords.AllowUserToResizeColumns = false;
            this.dgvWords.AllowUserToResizeRows = false;
            this.dgvWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Word,
            this.Frequency,
            this.IsPrime});
            this.dgvWords.Location = new System.Drawing.Point(12, 54);
            this.dgvWords.Name = "dgvWords";
            this.dgvWords.ReadOnly = true;
            this.dgvWords.Size = new System.Drawing.Size(447, 294);
            this.dgvWords.TabIndex = 2;
            this.dgvWords.Visible = false;
            // 
            // Word
            // 
            this.Word.DataPropertyName = "Word";
            this.Word.HeaderText = "Word";
            this.Word.Name = "Word";
            this.Word.ReadOnly = true;
            // 
            // Frequency
            // 
            this.Frequency.DataPropertyName = "Frequency";
            this.Frequency.HeaderText = "Frequency";
            this.Frequency.Name = "Frequency";
            this.Frequency.ReadOnly = true;
            // 
            // IsPrime
            // 
            this.IsPrime.DataPropertyName = "IsPrime";
            this.IsPrime.HeaderText = "IsPrime";
            this.IsPrime.Name = "IsPrime";
            this.IsPrime.ReadOnly = true;
            // 
            // WordCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 360);
            this.Controls.Add(this.dgvWords);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCountWords);
            this.Name = "WordCounter";
            this.Text = "Word Counter";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCountWords;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsPrime;
    }
}

