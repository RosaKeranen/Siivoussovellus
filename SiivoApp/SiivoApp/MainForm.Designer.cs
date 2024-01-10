namespace SiivoApp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.tossedRadioButton = new System.Windows.Forms.RadioButton();
            this.acquiredRadioButton = new System.Windows.Forms.RadioButton();
            this.thrownAwayRadioButton = new System.Windows.Forms.RadioButton();
            this.charityRadioButton = new System.Windows.Forms.RadioButton();
            this.soldRadioButton = new System.Windows.Forms.RadioButton();
            this.newPurchaseRadioButton = new System.Windows.Forms.RadioButton();
            this.freeRadioButton = new System.Windows.Forms.RadioButton();
            this.secondhandPurchaseRadioButton = new System.Windows.Forms.RadioButton();
            this.viewButton = new System.Windows.Forms.Button();
            this.viewTossedListRadioButton = new System.Windows.Forms.RadioButton();
            this.viewAcquiredListRadioButton = new System.Windows.Forms.RadioButton();
            this.tossedTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.acquiredTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.chooseViewGroupBox = new System.Windows.Forms.GroupBox();
            this.tossedTypeGroupBox.SuspendLayout();
            this.acquiredTypeGroupBox.SuspendLayout();
            this.chooseViewGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 20);
            this.textBox1.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(323, 33);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(82, 31);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Lisää listalle";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tossedRadioButton
            // 
            this.tossedRadioButton.AutoSize = true;
            this.tossedRadioButton.Location = new System.Drawing.Point(36, 76);
            this.tossedRadioButton.Name = "tossedRadioButton";
            this.tossedRadioButton.Size = new System.Drawing.Size(60, 17);
            this.tossedRadioButton.TabIndex = 2;
            this.tossedRadioButton.TabStop = true;
            this.tossedRadioButton.Text = "Siivottu";
            this.tossedRadioButton.UseVisualStyleBackColor = true;
            this.tossedRadioButton.CheckedChanged += new System.EventHandler(this.tossedRadioButton_CheckedChanged);
            // 
            // acquiredRadioButton
            // 
            this.acquiredRadioButton.AutoSize = true;
            this.acquiredRadioButton.Location = new System.Drawing.Point(162, 76);
            this.acquiredRadioButton.Name = "acquiredRadioButton";
            this.acquiredRadioButton.Size = new System.Drawing.Size(65, 17);
            this.acquiredRadioButton.TabIndex = 3;
            this.acquiredRadioButton.TabStop = true;
            this.acquiredRadioButton.Text = "Hankittu";
            this.acquiredRadioButton.UseVisualStyleBackColor = true;
            this.acquiredRadioButton.CheckedChanged += new System.EventHandler(this.acquiredRadioButton_CheckedChanged);
            // 
            // thrownAwayRadioButton
            // 
            this.thrownAwayRadioButton.AutoSize = true;
            this.thrownAwayRadioButton.Location = new System.Drawing.Point(6, 20);
            this.thrownAwayRadioButton.Name = "thrownAwayRadioButton";
            this.thrownAwayRadioButton.Size = new System.Drawing.Size(94, 17);
            this.thrownAwayRadioButton.TabIndex = 4;
            this.thrownAwayRadioButton.TabStop = true;
            this.thrownAwayRadioButton.Text = "Heitetty roskiin";
            this.thrownAwayRadioButton.UseVisualStyleBackColor = true;
            // 
            // charityRadioButton
            // 
            this.charityRadioButton.AutoSize = true;
            this.charityRadioButton.Location = new System.Drawing.Point(6, 44);
            this.charityRadioButton.Name = "charityRadioButton";
            this.charityRadioButton.Size = new System.Drawing.Size(84, 17);
            this.charityRadioButton.TabIndex = 5;
            this.charityRadioButton.TabStop = true;
            this.charityRadioButton.Text = "Annettu pois";
            this.charityRadioButton.UseVisualStyleBackColor = true;
            // 
            // soldRadioButton
            // 
            this.soldRadioButton.AutoSize = true;
            this.soldRadioButton.Location = new System.Drawing.Point(6, 66);
            this.soldRadioButton.Name = "soldRadioButton";
            this.soldRadioButton.Size = new System.Drawing.Size(52, 17);
            this.soldRadioButton.TabIndex = 6;
            this.soldRadioButton.TabStop = true;
            this.soldRadioButton.Text = "Myyty";
            this.soldRadioButton.UseVisualStyleBackColor = true;
            // 
            // newPurchaseRadioButton
            // 
            this.newPurchaseRadioButton.AutoSize = true;
            this.newPurchaseRadioButton.Location = new System.Drawing.Point(7, 19);
            this.newPurchaseRadioButton.Name = "newPurchaseRadioButton";
            this.newPurchaseRadioButton.Size = new System.Drawing.Size(95, 17);
            this.newPurchaseRadioButton.TabIndex = 7;
            this.newPurchaseRadioButton.TabStop = true;
            this.newPurchaseRadioButton.Text = "Ostettu uutena";
            this.newPurchaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // freeRadioButton
            // 
            this.freeRadioButton.AutoSize = true;
            this.freeRadioButton.Location = new System.Drawing.Point(7, 38);
            this.freeRadioButton.Name = "freeRadioButton";
            this.freeRadioButton.Size = new System.Drawing.Size(100, 17);
            this.freeRadioButton.TabIndex = 8;
            this.freeRadioButton.TabStop = true;
            this.freeRadioButton.Text = "Saatu ilmaiseksi";
            this.freeRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondhandPurchaseRadioButton
            // 
            this.secondhandPurchaseRadioButton.AutoSize = true;
            this.secondhandPurchaseRadioButton.Location = new System.Drawing.Point(7, 61);
            this.secondhandPurchaseRadioButton.Name = "secondhandPurchaseRadioButton";
            this.secondhandPurchaseRadioButton.Size = new System.Drawing.Size(111, 17);
            this.secondhandPurchaseRadioButton.TabIndex = 9;
            this.secondhandPurchaseRadioButton.TabStop = true;
            this.secondhandPurchaseRadioButton.Text = "Ostettu käytettynä";
            this.secondhandPurchaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(26, 39);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(84, 41);
            this.viewButton.TabIndex = 10;
            this.viewButton.Text = "Katso listaa";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // viewTossedListRadioButton
            // 
            this.viewTossedListRadioButton.AutoSize = true;
            this.viewTossedListRadioButton.Location = new System.Drawing.Point(151, 39);
            this.viewTossedListRadioButton.Name = "viewTossedListRadioButton";
            this.viewTossedListRadioButton.Size = new System.Drawing.Size(96, 17);
            this.viewTossedListRadioButton.TabIndex = 11;
            this.viewTossedListRadioButton.TabStop = true;
            this.viewTossedListRadioButton.Text = "Siivotut tavarat";
            this.viewTossedListRadioButton.UseVisualStyleBackColor = true;
            // 
            // viewAcquiredListRadioButton
            // 
            this.viewAcquiredListRadioButton.AutoSize = true;
            this.viewAcquiredListRadioButton.Location = new System.Drawing.Point(151, 63);
            this.viewAcquiredListRadioButton.Name = "viewAcquiredListRadioButton";
            this.viewAcquiredListRadioButton.Size = new System.Drawing.Size(101, 17);
            this.viewAcquiredListRadioButton.TabIndex = 12;
            this.viewAcquiredListRadioButton.TabStop = true;
            this.viewAcquiredListRadioButton.Text = "Hankitut tavarat";
            this.viewAcquiredListRadioButton.UseVisualStyleBackColor = true;
            // 
            // tossedTypeGroupBox
            // 
            this.tossedTypeGroupBox.Controls.Add(this.thrownAwayRadioButton);
            this.tossedTypeGroupBox.Controls.Add(this.charityRadioButton);
            this.tossedTypeGroupBox.Controls.Add(this.soldRadioButton);
            this.tossedTypeGroupBox.Location = new System.Drawing.Point(36, 116);
            this.tossedTypeGroupBox.Name = "tossedTypeGroupBox";
            this.tossedTypeGroupBox.Size = new System.Drawing.Size(112, 90);
            this.tossedTypeGroupBox.TabIndex = 13;
            this.tossedTypeGroupBox.TabStop = false;
            this.tossedTypeGroupBox.Text = "Mihin nakkasit?";
            // 
            // acquiredTypeGroupBox
            // 
            this.acquiredTypeGroupBox.Controls.Add(this.newPurchaseRadioButton);
            this.acquiredTypeGroupBox.Controls.Add(this.secondhandPurchaseRadioButton);
            this.acquiredTypeGroupBox.Controls.Add(this.freeRadioButton);
            this.acquiredTypeGroupBox.Location = new System.Drawing.Point(161, 116);
            this.acquiredTypeGroupBox.Name = "acquiredTypeGroupBox";
            this.acquiredTypeGroupBox.Size = new System.Drawing.Size(129, 90);
            this.acquiredTypeGroupBox.TabIndex = 14;
            this.acquiredTypeGroupBox.TabStop = false;
            this.acquiredTypeGroupBox.Text = "Miten hankit?";
            // 
            // chooseViewGroupBox
            // 
            this.chooseViewGroupBox.Controls.Add(this.viewTossedListRadioButton);
            this.chooseViewGroupBox.Controls.Add(this.viewButton);
            this.chooseViewGroupBox.Controls.Add(this.viewAcquiredListRadioButton);
            this.chooseViewGroupBox.Location = new System.Drawing.Point(36, 228);
            this.chooseViewGroupBox.Name = "chooseViewGroupBox";
            this.chooseViewGroupBox.Size = new System.Drawing.Size(281, 112);
            this.chooseViewGroupBox.TabIndex = 15;
            this.chooseViewGroupBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(417, 372);
            this.Controls.Add(this.chooseViewGroupBox);
            this.Controls.Add(this.acquiredTypeGroupBox);
            this.Controls.Add(this.tossedTypeGroupBox);
            this.Controls.Add(this.acquiredRadioButton);
            this.Controls.Add(this.tossedRadioButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Siivoussovellus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tossedTypeGroupBox.ResumeLayout(false);
            this.tossedTypeGroupBox.PerformLayout();
            this.acquiredTypeGroupBox.ResumeLayout(false);
            this.acquiredTypeGroupBox.PerformLayout();
            this.chooseViewGroupBox.ResumeLayout(false);
            this.chooseViewGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RadioButton tossedRadioButton;
        private System.Windows.Forms.RadioButton acquiredRadioButton;
        private System.Windows.Forms.RadioButton thrownAwayRadioButton;
        private System.Windows.Forms.RadioButton charityRadioButton;
        private System.Windows.Forms.RadioButton soldRadioButton;
        private System.Windows.Forms.RadioButton newPurchaseRadioButton;
        private System.Windows.Forms.RadioButton freeRadioButton;
        private System.Windows.Forms.RadioButton secondhandPurchaseRadioButton;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.RadioButton viewTossedListRadioButton;
        private System.Windows.Forms.RadioButton viewAcquiredListRadioButton;
        private System.Windows.Forms.GroupBox tossedTypeGroupBox;
        private System.Windows.Forms.GroupBox acquiredTypeGroupBox;
        private System.Windows.Forms.GroupBox chooseViewGroupBox;
    }
}

