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
            this.textBox1.Location = new System.Drawing.Point(54, 60);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(402, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(484, 51);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(123, 48);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Lisää listalle";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tossedRadioButton
            // 
            this.tossedRadioButton.AutoSize = true;
            this.tossedRadioButton.Location = new System.Drawing.Point(54, 117);
            this.tossedRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tossedRadioButton.Name = "tossedRadioButton";
            this.tossedRadioButton.Size = new System.Drawing.Size(79, 24);
            this.tossedRadioButton.TabIndex = 2;
            this.tossedRadioButton.TabStop = true;
            this.tossedRadioButton.Text = "Siivottu";
            this.tossedRadioButton.UseVisualStyleBackColor = true;
            this.tossedRadioButton.CheckedChanged += new System.EventHandler(this.tossedRadioButton_CheckedChanged);
            // 
            // acquiredRadioButton
            // 
            this.acquiredRadioButton.AutoSize = true;
            this.acquiredRadioButton.Location = new System.Drawing.Point(243, 117);
            this.acquiredRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.acquiredRadioButton.Name = "acquiredRadioButton";
            this.acquiredRadioButton.Size = new System.Drawing.Size(87, 24);
            this.acquiredRadioButton.TabIndex = 3;
            this.acquiredRadioButton.TabStop = true;
            this.acquiredRadioButton.Text = "Hankittu";
            this.acquiredRadioButton.UseVisualStyleBackColor = true;
            this.acquiredRadioButton.CheckedChanged += new System.EventHandler(this.acquiredRadioButton_CheckedChanged);
            // 
            // thrownAwayRadioButton
            // 
            this.thrownAwayRadioButton.AutoSize = true;
            this.thrownAwayRadioButton.Location = new System.Drawing.Point(9, 31);
            this.thrownAwayRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.thrownAwayRadioButton.Name = "thrownAwayRadioButton";
            this.thrownAwayRadioButton.Size = new System.Drawing.Size(131, 24);
            this.thrownAwayRadioButton.TabIndex = 4;
            this.thrownAwayRadioButton.TabStop = true;
            this.thrownAwayRadioButton.Text = "Heitetty roskiin";
            this.thrownAwayRadioButton.UseVisualStyleBackColor = true;
            this.thrownAwayRadioButton.CheckedChanged += new System.EventHandler(this.thrownAwayRadioButton_CheckedChanged);
            // 
            // charityRadioButton
            // 
            this.charityRadioButton.AutoSize = true;
            this.charityRadioButton.Location = new System.Drawing.Point(9, 68);
            this.charityRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.charityRadioButton.Name = "charityRadioButton";
            this.charityRadioButton.Size = new System.Drawing.Size(117, 24);
            this.charityRadioButton.TabIndex = 5;
            this.charityRadioButton.TabStop = true;
            this.charityRadioButton.Text = "Annettu pois";
            this.charityRadioButton.UseVisualStyleBackColor = true;
            this.charityRadioButton.CheckedChanged += new System.EventHandler(this.charityRadioButton_CheckedChanged);
            // 
            // soldRadioButton
            // 
            this.soldRadioButton.AutoSize = true;
            this.soldRadioButton.Location = new System.Drawing.Point(9, 102);
            this.soldRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.soldRadioButton.Name = "soldRadioButton";
            this.soldRadioButton.Size = new System.Drawing.Size(66, 24);
            this.soldRadioButton.TabIndex = 6;
            this.soldRadioButton.TabStop = true;
            this.soldRadioButton.Text = "Myyty";
            this.soldRadioButton.UseVisualStyleBackColor = true;
            this.soldRadioButton.CheckedChanged += new System.EventHandler(this.soldRadioButton_CheckedChanged);
            // 
            // newPurchaseRadioButton
            // 
            this.newPurchaseRadioButton.AutoSize = true;
            this.newPurchaseRadioButton.Location = new System.Drawing.Point(10, 29);
            this.newPurchaseRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newPurchaseRadioButton.Name = "newPurchaseRadioButton";
            this.newPurchaseRadioButton.Size = new System.Drawing.Size(134, 24);
            this.newPurchaseRadioButton.TabIndex = 7;
            this.newPurchaseRadioButton.TabStop = true;
            this.newPurchaseRadioButton.Text = "Ostettu uutena";
            this.newPurchaseRadioButton.UseVisualStyleBackColor = true;
            this.newPurchaseRadioButton.CheckedChanged += new System.EventHandler(this.newPurchaseRadioButton_CheckedChanged);
            // 
            // freeRadioButton
            // 
            this.freeRadioButton.AutoSize = true;
            this.freeRadioButton.Location = new System.Drawing.Point(10, 58);
            this.freeRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.freeRadioButton.Name = "freeRadioButton";
            this.freeRadioButton.Size = new System.Drawing.Size(141, 24);
            this.freeRadioButton.TabIndex = 8;
            this.freeRadioButton.TabStop = true;
            this.freeRadioButton.Text = "Saatu ilmaiseksi";
            this.freeRadioButton.UseVisualStyleBackColor = true;
            this.freeRadioButton.CheckedChanged += new System.EventHandler(this.freeRadioButton_CheckedChanged);
            // 
            // secondhandPurchaseRadioButton
            // 
            this.secondhandPurchaseRadioButton.AutoSize = true;
            this.secondhandPurchaseRadioButton.Location = new System.Drawing.Point(10, 94);
            this.secondhandPurchaseRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secondhandPurchaseRadioButton.Name = "secondhandPurchaseRadioButton";
            this.secondhandPurchaseRadioButton.Size = new System.Drawing.Size(157, 24);
            this.secondhandPurchaseRadioButton.TabIndex = 9;
            this.secondhandPurchaseRadioButton.TabStop = true;
            this.secondhandPurchaseRadioButton.Text = "Ostettu käytettynä";
            this.secondhandPurchaseRadioButton.UseVisualStyleBackColor = true;
            this.secondhandPurchaseRadioButton.CheckedChanged += new System.EventHandler(this.secondhandPurchaseRadioButton_CheckedChanged);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(39, 60);
            this.viewButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(126, 63);
            this.viewButton.TabIndex = 10;
            this.viewButton.Text = "Katso listaa";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // viewTossedListRadioButton
            // 
            this.viewTossedListRadioButton.AutoSize = true;
            this.viewTossedListRadioButton.Location = new System.Drawing.Point(226, 60);
            this.viewTossedListRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewTossedListRadioButton.Name = "viewTossedListRadioButton";
            this.viewTossedListRadioButton.Size = new System.Drawing.Size(132, 24);
            this.viewTossedListRadioButton.TabIndex = 11;
            this.viewTossedListRadioButton.TabStop = true;
            this.viewTossedListRadioButton.Text = "Siivotut tavarat";
            this.viewTossedListRadioButton.UseVisualStyleBackColor = true;
            this.viewTossedListRadioButton.CheckedChanged += new System.EventHandler(this.viewTossedListRadioButton_CheckedChanged);
            // 
            // viewAcquiredListRadioButton
            // 
            this.viewAcquiredListRadioButton.AutoSize = true;
            this.viewAcquiredListRadioButton.Location = new System.Drawing.Point(226, 97);
            this.viewAcquiredListRadioButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewAcquiredListRadioButton.Name = "viewAcquiredListRadioButton";
            this.viewAcquiredListRadioButton.Size = new System.Drawing.Size(140, 24);
            this.viewAcquiredListRadioButton.TabIndex = 12;
            this.viewAcquiredListRadioButton.TabStop = true;
            this.viewAcquiredListRadioButton.Text = "Hankitut tavarat";
            this.viewAcquiredListRadioButton.UseVisualStyleBackColor = true;
            this.viewAcquiredListRadioButton.CheckedChanged += new System.EventHandler(this.viewAcquiredListRadioButton_CheckedChanged);
            // 
            // tossedTypeGroupBox
            // 
            this.tossedTypeGroupBox.Controls.Add(this.thrownAwayRadioButton);
            this.tossedTypeGroupBox.Controls.Add(this.charityRadioButton);
            this.tossedTypeGroupBox.Controls.Add(this.soldRadioButton);
            this.tossedTypeGroupBox.Location = new System.Drawing.Point(54, 178);
            this.tossedTypeGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tossedTypeGroupBox.Name = "tossedTypeGroupBox";
            this.tossedTypeGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tossedTypeGroupBox.Size = new System.Drawing.Size(168, 138);
            this.tossedTypeGroupBox.TabIndex = 13;
            this.tossedTypeGroupBox.TabStop = false;
            this.tossedTypeGroupBox.Text = "Mihin nakkasit?";
            this.tossedTypeGroupBox.Enter += new System.EventHandler(this.tossedTypeGroupBox_Enter);
            // 
            // acquiredTypeGroupBox
            // 
            this.acquiredTypeGroupBox.Controls.Add(this.newPurchaseRadioButton);
            this.acquiredTypeGroupBox.Controls.Add(this.secondhandPurchaseRadioButton);
            this.acquiredTypeGroupBox.Controls.Add(this.freeRadioButton);
            this.acquiredTypeGroupBox.Location = new System.Drawing.Point(242, 178);
            this.acquiredTypeGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.acquiredTypeGroupBox.Name = "acquiredTypeGroupBox";
            this.acquiredTypeGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.acquiredTypeGroupBox.Size = new System.Drawing.Size(194, 138);
            this.acquiredTypeGroupBox.TabIndex = 14;
            this.acquiredTypeGroupBox.TabStop = false;
            this.acquiredTypeGroupBox.Text = "Miten hankit?";
            this.acquiredTypeGroupBox.Enter += new System.EventHandler(this.acquiredTypeGroupBox_Enter);
            // 
            // chooseViewGroupBox
            // 
            this.chooseViewGroupBox.Controls.Add(this.viewTossedListRadioButton);
            this.chooseViewGroupBox.Controls.Add(this.viewButton);
            this.chooseViewGroupBox.Controls.Add(this.viewAcquiredListRadioButton);
            this.chooseViewGroupBox.Location = new System.Drawing.Point(54, 351);
            this.chooseViewGroupBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chooseViewGroupBox.Name = "chooseViewGroupBox";
            this.chooseViewGroupBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chooseViewGroupBox.Size = new System.Drawing.Size(422, 172);
            this.chooseViewGroupBox.TabIndex = 15;
            this.chooseViewGroupBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 572);
            this.Controls.Add(this.chooseViewGroupBox);
            this.Controls.Add(this.acquiredTypeGroupBox);
            this.Controls.Add(this.tossedTypeGroupBox);
            this.Controls.Add(this.acquiredRadioButton);
            this.Controls.Add(this.tossedRadioButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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

