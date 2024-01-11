namespace SiivoApp
{
    partial class TossedForm
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
            this.thrownAwayListBox = new System.Windows.Forms.ListBox();
            this.charityListBox = new System.Windows.Forms.ListBox();
            this.soldListBox = new System.Windows.Forms.ListBox();
            this.thrownAwayLabel = new System.Windows.Forms.Label();
            this.tossedViewLabel = new System.Windows.Forms.Label();
            this.charityLabel = new System.Windows.Forms.Label();
            this.soldLabel = new System.Windows.Forms.Label();
            this.thrownAwayCountLabel = new System.Windows.Forms.Label();
            this.charityCountLabel = new System.Windows.Forms.Label();
            this.soldCountLabel = new System.Windows.Forms.Label();
            this.deleteTossedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // thrownAwayListBox
            // 
            this.thrownAwayListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thrownAwayListBox.FormattingEnabled = true;
            this.thrownAwayListBox.ItemHeight = 15;
            this.thrownAwayListBox.Location = new System.Drawing.Point(21, 132);
            this.thrownAwayListBox.Name = "thrownAwayListBox";
            this.thrownAwayListBox.Size = new System.Drawing.Size(213, 244);
            this.thrownAwayListBox.TabIndex = 0;
            // 
            // charityListBox
            // 
            this.charityListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charityListBox.FormattingEnabled = true;
            this.charityListBox.ItemHeight = 15;
            this.charityListBox.Location = new System.Drawing.Point(254, 132);
            this.charityListBox.Name = "charityListBox";
            this.charityListBox.Size = new System.Drawing.Size(213, 244);
            this.charityListBox.TabIndex = 1;
            // 
            // soldListBox
            // 
            this.soldListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldListBox.FormattingEnabled = true;
            this.soldListBox.ItemHeight = 15;
            this.soldListBox.Location = new System.Drawing.Point(492, 132);
            this.soldListBox.Name = "soldListBox";
            this.soldListBox.Size = new System.Drawing.Size(213, 244);
            this.soldListBox.TabIndex = 2;
            // 
            // thrownAwayLabel
            // 
            this.thrownAwayLabel.AutoSize = true;
            this.thrownAwayLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thrownAwayLabel.Location = new System.Drawing.Point(65, 93);
            this.thrownAwayLabel.Name = "thrownAwayLabel";
            this.thrownAwayLabel.Size = new System.Drawing.Size(113, 20);
            this.thrownAwayLabel.TabIndex = 3;
            this.thrownAwayLabel.Text = "Heitetty roskiin";
            // 
            // tossedViewLabel
            // 
            this.tossedViewLabel.AutoSize = true;
            this.tossedViewLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tossedViewLabel.Location = new System.Drawing.Point(296, 32);
            this.tossedViewLabel.Name = "tossedViewLabel";
            this.tossedViewLabel.Size = new System.Drawing.Size(123, 25);
            this.tossedViewLabel.TabIndex = 4;
            this.tossedViewLabel.Text = "Siivotut asiat";
            // 
            // charityLabel
            // 
            this.charityLabel.AutoSize = true;
            this.charityLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charityLabel.Location = new System.Drawing.Point(306, 93);
            this.charityLabel.Name = "charityLabel";
            this.charityLabel.Size = new System.Drawing.Size(96, 20);
            this.charityLabel.TabIndex = 5;
            this.charityLabel.Text = "Annettu pois";
            // 
            // soldLabel
            // 
            this.soldLabel.AutoSize = true;
            this.soldLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldLabel.Location = new System.Drawing.Point(562, 93);
            this.soldLabel.Name = "soldLabel";
            this.soldLabel.Size = new System.Drawing.Size(52, 20);
            this.soldLabel.TabIndex = 6;
            this.soldLabel.Text = "Myyty";
            // 
            // thrownAwayCountLabel
            // 
            this.thrownAwayCountLabel.AutoSize = true;
            this.thrownAwayCountLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thrownAwayCountLabel.Location = new System.Drawing.Point(18, 396);
            this.thrownAwayCountLabel.Name = "thrownAwayCountLabel";
            this.thrownAwayCountLabel.Size = new System.Drawing.Size(160, 13);
            this.thrownAwayCountLabel.TabIndex = 7;
            this.thrownAwayCountLabel.Text = "Roskiin heitettyjen lukumäärä";
            // 
            // charityCountLabel
            // 
            this.charityCountLabel.AutoSize = true;
            this.charityCountLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charityCountLabel.Location = new System.Drawing.Point(257, 396);
            this.charityCountLabel.Name = "charityCountLabel";
            this.charityCountLabel.Size = new System.Drawing.Size(145, 13);
            this.charityCountLabel.TabIndex = 8;
            this.charityCountLabel.Text = "Pois annettujen lukumäärä";
            // 
            // soldCountLabel
            // 
            this.soldCountLabel.AutoSize = true;
            this.soldCountLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldCountLabel.Location = new System.Drawing.Point(489, 396);
            this.soldCountLabel.Name = "soldCountLabel";
            this.soldCountLabel.Size = new System.Drawing.Size(109, 13);
            this.soldCountLabel.TabIndex = 9;
            this.soldCountLabel.Text = "Myytyjen lukumäärä";
            // 
            // deleteTossedButton
            // 
            this.deleteTossedButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTossedButton.Location = new System.Drawing.Point(614, 438);
            this.deleteTossedButton.Name = "deleteTossedButton";
            this.deleteTossedButton.Size = new System.Drawing.Size(91, 37);
            this.deleteTossedButton.TabIndex = 10;
            this.deleteTossedButton.Text = "Poista listalta";
            this.deleteTossedButton.UseVisualStyleBackColor = true;
            this.deleteTossedButton.Click += new System.EventHandler(this.deleteTossedButton_Click);
            // 
            // TossedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 507);
            this.Controls.Add(this.deleteTossedButton);
            this.Controls.Add(this.soldCountLabel);
            this.Controls.Add(this.charityCountLabel);
            this.Controls.Add(this.thrownAwayCountLabel);
            this.Controls.Add(this.soldLabel);
            this.Controls.Add(this.charityLabel);
            this.Controls.Add(this.tossedViewLabel);
            this.Controls.Add(this.thrownAwayLabel);
            this.Controls.Add(this.soldListBox);
            this.Controls.Add(this.charityListBox);
            this.Controls.Add(this.thrownAwayListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TossedForm";
            this.Text = "Siivotut asiat";
            this.Load += new System.EventHandler(this.TossedForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox thrownAwayListBox;
        private System.Windows.Forms.ListBox charityListBox;
        private System.Windows.Forms.ListBox soldListBox;
        private System.Windows.Forms.Label thrownAwayLabel;
        private System.Windows.Forms.Label tossedViewLabel;
        private System.Windows.Forms.Label charityLabel;
        private System.Windows.Forms.Label soldLabel;
        private System.Windows.Forms.Label thrownAwayCountLabel;
        private System.Windows.Forms.Label charityCountLabel;
        private System.Windows.Forms.Label soldCountLabel;
        private System.Windows.Forms.Button deleteTossedButton;
    }
}