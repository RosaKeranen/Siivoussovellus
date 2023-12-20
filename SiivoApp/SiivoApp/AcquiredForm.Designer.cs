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
            this.newPurchaseCountLabel = new System.Windows.Forms.Label();
            this.freeCountLabel = new System.Windows.Forms.Label();
            this.secondhandCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newPurchaseListBox
            // 
            this.newPurchaseListBox.FormattingEnabled = true;
            this.newPurchaseListBox.ItemHeight = 20;
            this.newPurchaseListBox.Location = new System.Drawing.Point(72, 169);
            this.newPurchaseListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newPurchaseListBox.Name = "newPurchaseListBox";
            this.newPurchaseListBox.Size = new System.Drawing.Size(301, 384);
            this.newPurchaseListBox.TabIndex = 0;
            // 
            // secondhandListBox
            // 
            this.secondhandListBox.FormattingEnabled = true;
            this.secondhandListBox.ItemHeight = 20;
            this.secondhandListBox.Location = new System.Drawing.Point(740, 169);
            this.secondhandListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secondhandListBox.Name = "secondhandListBox";
            this.secondhandListBox.Size = new System.Drawing.Size(301, 384);
            this.secondhandListBox.TabIndex = 1;
            // 
            // freeListBox
            // 
            this.freeListBox.FormattingEnabled = true;
            this.freeListBox.ItemHeight = 20;
            this.freeListBox.Location = new System.Drawing.Point(406, 169);
            this.freeListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.freeListBox.Name = "freeListBox";
            this.freeListBox.Size = new System.Drawing.Size(301, 384);
            this.freeListBox.TabIndex = 2;
            // 
            // acquiredViewLabel
            // 
            this.acquiredViewLabel.AutoSize = true;
            this.acquiredViewLabel.Location = new System.Drawing.Point(488, 57);
            this.acquiredViewLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.acquiredViewLabel.Name = "acquiredViewLabel";
            this.acquiredViewLabel.Size = new System.Drawing.Size(107, 20);
            this.acquiredViewLabel.TabIndex = 3;
            this.acquiredViewLabel.Text = "Hankitut asiat";
            // 
            // newPurchaseLabel
            // 
            this.newPurchaseLabel.AutoSize = true;
            this.newPurchaseLabel.Location = new System.Drawing.Point(68, 126);
            this.newPurchaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newPurchaseLabel.Name = "newPurchaseLabel";
            this.newPurchaseLabel.Size = new System.Drawing.Size(116, 20);
            this.newPurchaseLabel.TabIndex = 4;
            this.newPurchaseLabel.Text = "Ostettu uutena";
            // 
            // freeLabel
            // 
            this.freeLabel.AutoSize = true;
            this.freeLabel.Location = new System.Drawing.Point(406, 126);
            this.freeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.freeLabel.Name = "freeLabel";
            this.freeLabel.Size = new System.Drawing.Size(123, 20);
            this.freeLabel.TabIndex = 5;
            this.freeLabel.Text = "Saatu ilmaiseksi";
            // 
            // secondhandLabel
            // 
            this.secondhandLabel.AutoSize = true;
            this.secondhandLabel.Location = new System.Drawing.Point(735, 126);
            this.secondhandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secondhandLabel.Name = "secondhandLabel";
            this.secondhandLabel.Size = new System.Drawing.Size(139, 20);
            this.secondhandLabel.TabIndex = 6;
            this.secondhandLabel.Text = "Ostettu käytettynä";
            // 
            // newPurchaseCountLabel
            // 
            this.newPurchaseCountLabel.AutoSize = true;
            this.newPurchaseCountLabel.Location = new System.Drawing.Point(68, 578);
            this.newPurchaseCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newPurchaseCountLabel.Name = "newPurchaseCountLabel";
            this.newPurchaseCountLabel.Size = new System.Drawing.Size(215, 20);
            this.newPurchaseCountLabel.TabIndex = 7;
            this.newPurchaseCountLabel.Text = "Uutena ostettujen lukumäärä";
            // 
            // freeCountLabel
            // 
            this.freeCountLabel.AutoSize = true;
            this.freeCountLabel.Location = new System.Drawing.Point(411, 578);
            this.freeCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.freeCountLabel.Name = "freeCountLabel";
            this.freeCountLabel.Size = new System.Drawing.Size(221, 20);
            this.freeCountLabel.TabIndex = 8;
            this.freeCountLabel.Text = "Ilmaiseksi saatujen lukumäärä";
            // 
            // secondhandCountLabel
            // 
            this.secondhandCountLabel.AutoSize = true;
            this.secondhandCountLabel.Location = new System.Drawing.Point(740, 578);
            this.secondhandCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secondhandCountLabel.Name = "secondhandCountLabel";
            this.secondhandCountLabel.Size = new System.Drawing.Size(237, 20);
            this.secondhandCountLabel.TabIndex = 9;
            this.secondhandCountLabel.Text = "Käytettynä ostettujen lukumäärä";
            // 
            // AcquiredForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.secondhandCountLabel);
            this.Controls.Add(this.freeCountLabel);
            this.Controls.Add(this.newPurchaseCountLabel);
            this.Controls.Add(this.secondhandLabel);
            this.Controls.Add(this.freeLabel);
            this.Controls.Add(this.newPurchaseLabel);
            this.Controls.Add(this.acquiredViewLabel);
            this.Controls.Add(this.freeListBox);
            this.Controls.Add(this.secondhandListBox);
            this.Controls.Add(this.newPurchaseListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AcquiredForm";
            this.Text = "Hankitut asiat";
            this.Load += new System.EventHandler(this.AcquiredForm_Load);
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
        private System.Windows.Forms.Label newPurchaseCountLabel;
        private System.Windows.Forms.Label freeCountLabel;
        private System.Windows.Forms.Label secondhandCountLabel;
    }
}