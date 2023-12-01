namespace SiivoApp
{
    partial class AcquiredForm
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
            this.newPurchaseListBox = new System.Windows.Forms.ListBox();
            this.secondhandListBox = new System.Windows.Forms.ListBox();
            this.freeListBox = new System.Windows.Forms.ListBox();
            this.acquiredViewLabel = new System.Windows.Forms.Label();
            this.newPurchaseLabel = new System.Windows.Forms.Label();
            this.freeLabel = new System.Windows.Forms.Label();
            this.secondhandLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newPurchaseListBox
            // 
            this.newPurchaseListBox.FormattingEnabled = true;
            this.newPurchaseListBox.Location = new System.Drawing.Point(48, 110);
            this.newPurchaseListBox.Name = "newPurchaseListBox";
            this.newPurchaseListBox.Size = new System.Drawing.Size(202, 251);
            this.newPurchaseListBox.TabIndex = 0;
            // 
            // secondhandListBox
            // 
            this.secondhandListBox.FormattingEnabled = true;
            this.secondhandListBox.Location = new System.Drawing.Point(493, 110);
            this.secondhandListBox.Name = "secondhandListBox";
            this.secondhandListBox.Size = new System.Drawing.Size(202, 251);
            this.secondhandListBox.TabIndex = 1;
            // 
            // freeListBox
            // 
            this.freeListBox.FormattingEnabled = true;
            this.freeListBox.Location = new System.Drawing.Point(271, 110);
            this.freeListBox.Name = "freeListBox";
            this.freeListBox.Size = new System.Drawing.Size(202, 251);
            this.freeListBox.TabIndex = 2;
            // 
            // acquiredViewLabel
            // 
            this.acquiredViewLabel.AutoSize = true;
            this.acquiredViewLabel.Location = new System.Drawing.Point(325, 37);
            this.acquiredViewLabel.Name = "acquiredViewLabel";
            this.acquiredViewLabel.Size = new System.Drawing.Size(72, 13);
            this.acquiredViewLabel.TabIndex = 3;
            this.acquiredViewLabel.Text = "Hankitut asiat";
            // 
            // newPurchaseLabel
            // 
            this.newPurchaseLabel.AutoSize = true;
            this.newPurchaseLabel.Location = new System.Drawing.Point(45, 82);
            this.newPurchaseLabel.Name = "newPurchaseLabel";
            this.newPurchaseLabel.Size = new System.Drawing.Size(77, 13);
            this.newPurchaseLabel.TabIndex = 4;
            this.newPurchaseLabel.Text = "Ostettu uutena";
            // 
            // freeLabel
            // 
            this.freeLabel.AutoSize = true;
            this.freeLabel.Location = new System.Drawing.Point(271, 82);
            this.freeLabel.Name = "freeLabel";
            this.freeLabel.Size = new System.Drawing.Size(82, 13);
            this.freeLabel.TabIndex = 5;
            this.freeLabel.Text = "Saatu ilmaiseksi";
            // 
            // secondhandLabel
            // 
            this.secondhandLabel.AutoSize = true;
            this.secondhandLabel.Location = new System.Drawing.Point(490, 82);
            this.secondhandLabel.Name = "secondhandLabel";
            this.secondhandLabel.Size = new System.Drawing.Size(93, 13);
            this.secondhandLabel.TabIndex = 6;
            this.secondhandLabel.Text = "Ostettu käytettynä";
            // 
            // AcquiredForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.secondhandLabel);
            this.Controls.Add(this.freeLabel);
            this.Controls.Add(this.newPurchaseLabel);
            this.Controls.Add(this.acquiredViewLabel);
            this.Controls.Add(this.freeListBox);
            this.Controls.Add(this.secondhandListBox);
            this.Controls.Add(this.newPurchaseListBox);
            this.Name = "AcquiredForm";
            this.Text = "Hankitut asiat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox newPurchaseListBox;
        private System.Windows.Forms.ListBox secondhandListBox;
        private System.Windows.Forms.ListBox freeListBox;
        private System.Windows.Forms.Label acquiredViewLabel;
        private System.Windows.Forms.Label newPurchaseLabel;
        private System.Windows.Forms.Label freeLabel;
        private System.Windows.Forms.Label secondhandLabel;
    }
}