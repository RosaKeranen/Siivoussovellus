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
            this.acquiredDeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newPurchaseListBox
            // 
            this.newPurchaseListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPurchaseListBox.FormattingEnabled = true;
            this.newPurchaseListBox.ItemHeight = 15;
            this.newPurchaseListBox.Location = new System.Drawing.Point(21, 132);
            this.newPurchaseListBox.Name = "newPurchaseListBox";
            this.newPurchaseListBox.Size = new System.Drawing.Size(213, 244);
            this.newPurchaseListBox.TabIndex = 0;
            // 
            // secondhandListBox
            // 
            this.secondhandListBox.BackColor = System.Drawing.SystemColors.Window;
            this.secondhandListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondhandListBox.FormattingEnabled = true;
            this.secondhandListBox.ItemHeight = 15;
            this.secondhandListBox.Location = new System.Drawing.Point(492, 132);
            this.secondhandListBox.Name = "secondhandListBox";
            this.secondhandListBox.Size = new System.Drawing.Size(213, 244);
            this.secondhandListBox.TabIndex = 1;
            // 
            // freeListBox
            // 
            this.freeListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeListBox.FormattingEnabled = true;
            this.freeListBox.ItemHeight = 15;
            this.freeListBox.Location = new System.Drawing.Point(254, 132);
            this.freeListBox.Name = "freeListBox";
            this.freeListBox.Size = new System.Drawing.Size(213, 244);
            this.freeListBox.TabIndex = 2;
            // 
            // acquiredViewLabel
            // 
            this.acquiredViewLabel.AutoSize = true;
            this.acquiredViewLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acquiredViewLabel.Location = new System.Drawing.Point(296, 32);
            this.acquiredViewLabel.Name = "acquiredViewLabel";
            this.acquiredViewLabel.Size = new System.Drawing.Size(132, 25);
            this.acquiredViewLabel.TabIndex = 3;
            this.acquiredViewLabel.Text = "Hankitut asiat";
            // 
            // newPurchaseLabel
            // 
            this.newPurchaseLabel.AutoSize = true;
            this.newPurchaseLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPurchaseLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newPurchaseLabel.Location = new System.Drawing.Point(62, 93);
            this.newPurchaseLabel.Name = "newPurchaseLabel";
            this.newPurchaseLabel.Size = new System.Drawing.Size(110, 20);
            this.newPurchaseLabel.TabIndex = 4;
            this.newPurchaseLabel.Text = "Ostettu uutena";
            // 
            // freeLabel
            // 
            this.freeLabel.AutoSize = true;
            this.freeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeLabel.Location = new System.Drawing.Point(293, 93);
            this.freeLabel.Name = "freeLabel";
            this.freeLabel.Size = new System.Drawing.Size(116, 20);
            this.freeLabel.TabIndex = 5;
            this.freeLabel.Text = "Saatu ilmaiseksi";
            // 
            // secondhandLabel
            // 
            this.secondhandLabel.AutoSize = true;
            this.secondhandLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondhandLabel.Location = new System.Drawing.Point(525, 93);
            this.secondhandLabel.Name = "secondhandLabel";
            this.secondhandLabel.Size = new System.Drawing.Size(134, 20);
            this.secondhandLabel.TabIndex = 6;
            this.secondhandLabel.Text = "Ostettu käytettynä";
            // 
            // newPurchaseCountLabel
            // 
            this.newPurchaseCountLabel.AutoSize = true;
            this.newPurchaseCountLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPurchaseCountLabel.Location = new System.Drawing.Point(18, 396);
            this.newPurchaseCountLabel.Name = "newPurchaseCountLabel";
            this.newPurchaseCountLabel.Size = new System.Drawing.Size(158, 13);
            this.newPurchaseCountLabel.TabIndex = 7;
            this.newPurchaseCountLabel.Text = "Uutena ostettujen lukumäärä";
            this.newPurchaseCountLabel.Click += new System.EventHandler(this.newPurchaseCountLabel_Click);
            // 
            // freeCountLabel
            // 
            this.freeCountLabel.AutoSize = true;
            this.freeCountLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeCountLabel.Location = new System.Drawing.Point(251, 396);
            this.freeCountLabel.Name = "freeCountLabel";
            this.freeCountLabel.Size = new System.Drawing.Size(160, 13);
            this.freeCountLabel.TabIndex = 8;
            this.freeCountLabel.Text = "Ilmaiseksi saatujen lukumäärä";
            // 
            // secondhandCountLabel
            // 
            this.secondhandCountLabel.AutoSize = true;
            this.secondhandCountLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondhandCountLabel.Location = new System.Drawing.Point(489, 396);
            this.secondhandCountLabel.Name = "secondhandCountLabel";
            this.secondhandCountLabel.Size = new System.Drawing.Size(173, 13);
            this.secondhandCountLabel.TabIndex = 9;
            this.secondhandCountLabel.Text = "Käytettynä ostettujen lukumäärä";
            // 
            // acquiredDeleteButton
            // 
            this.acquiredDeleteButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acquiredDeleteButton.Location = new System.Drawing.Point(614, 438);
            this.acquiredDeleteButton.Name = "acquiredDeleteButton";
            this.acquiredDeleteButton.Size = new System.Drawing.Size(91, 37);
            this.acquiredDeleteButton.TabIndex = 10;
            this.acquiredDeleteButton.Text = "Poista listalta";
            this.acquiredDeleteButton.UseVisualStyleBackColor = true;
            this.acquiredDeleteButton.Click += new System.EventHandler(this.acquiredDeleteButton_Click);
            // 
            // AcquiredForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 507);
            this.Controls.Add(this.acquiredDeleteButton);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
        private System.Windows.Forms.Button acquiredDeleteButton;
    }
}