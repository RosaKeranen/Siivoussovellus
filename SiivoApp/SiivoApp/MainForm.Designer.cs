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
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(23, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 23);
            this.textBox1.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(312, 32);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(83, 33);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Lisää listalle";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // tossedRadioButton
            // 
            this.tossedRadioButton.AutoSize = true;
            this.tossedRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tossedRadioButton.Location = new System.Drawing.Point(23, 75);
            this.tossedRadioButton.Name = "tossedRadioButton";
            this.tossedRadioButton.Size = new System.Drawing.Size(68, 21);
            this.tossedRadioButton.TabIndex = 2;
            this.tossedRadioButton.TabStop = true;
            this.tossedRadioButton.Text = "Siivottu";
            this.tossedRadioButton.UseVisualStyleBackColor = true;
            this.tossedRadioButton.CheckedChanged += new System.EventHandler(this.tossedRadioButton_CheckedChanged);
            // 
            // acquiredRadioButton
            // 
            this.acquiredRadioButton.AutoSize = true;
            this.acquiredRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acquiredRadioButton.Location = new System.Drawing.Point(97, 75);
            this.acquiredRadioButton.Name = "acquiredRadioButton";
            this.acquiredRadioButton.Size = new System.Drawing.Size(73, 21);
            this.acquiredRadioButton.TabIndex = 3;
            this.acquiredRadioButton.TabStop = true;
            this.acquiredRadioButton.Text = "Hankittu";
            this.acquiredRadioButton.UseVisualStyleBackColor = true;
            this.acquiredRadioButton.CheckedChanged += new System.EventHandler(this.acquiredRadioButton_CheckedChanged);
            // 
            // thrownAwayRadioButton
            // 
            this.thrownAwayRadioButton.AutoSize = true;
            this.thrownAwayRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thrownAwayRadioButton.Location = new System.Drawing.Point(6, 20);
            this.thrownAwayRadioButton.Name = "thrownAwayRadioButton";
            this.thrownAwayRadioButton.Size = new System.Drawing.Size(112, 21);
            this.thrownAwayRadioButton.TabIndex = 4;
            this.thrownAwayRadioButton.TabStop = true;
            this.thrownAwayRadioButton.Text = "Heitetty roskiin";
            this.thrownAwayRadioButton.UseVisualStyleBackColor = true;
            // 
            // charityRadioButton
            // 
            this.charityRadioButton.AutoSize = true;
            this.charityRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charityRadioButton.Location = new System.Drawing.Point(6, 44);
            this.charityRadioButton.Name = "charityRadioButton";
            this.charityRadioButton.Size = new System.Drawing.Size(99, 21);
            this.charityRadioButton.TabIndex = 5;
            this.charityRadioButton.TabStop = true;
            this.charityRadioButton.Text = "Annettu pois";
            this.charityRadioButton.UseVisualStyleBackColor = true;
            // 
            // soldRadioButton
            // 
            this.soldRadioButton.AutoSize = true;
            this.soldRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldRadioButton.Location = new System.Drawing.Point(6, 66);
            this.soldRadioButton.Name = "soldRadioButton";
            this.soldRadioButton.Size = new System.Drawing.Size(60, 21);
            this.soldRadioButton.TabIndex = 6;
            this.soldRadioButton.TabStop = true;
            this.soldRadioButton.Text = "Myyty";
            this.soldRadioButton.UseVisualStyleBackColor = true;
            // 
            // newPurchaseRadioButton
            // 
            this.newPurchaseRadioButton.AutoSize = true;
            this.newPurchaseRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPurchaseRadioButton.Location = new System.Drawing.Point(7, 19);
            this.newPurchaseRadioButton.Name = "newPurchaseRadioButton";
            this.newPurchaseRadioButton.Size = new System.Drawing.Size(111, 21);
            this.newPurchaseRadioButton.TabIndex = 7;
            this.newPurchaseRadioButton.TabStop = true;
            this.newPurchaseRadioButton.Text = "Ostettu uutena";
            this.newPurchaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // freeRadioButton
            // 
            this.freeRadioButton.AutoSize = true;
            this.freeRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freeRadioButton.Location = new System.Drawing.Point(7, 38);
            this.freeRadioButton.Name = "freeRadioButton";
            this.freeRadioButton.Size = new System.Drawing.Size(117, 21);
            this.freeRadioButton.TabIndex = 8;
            this.freeRadioButton.TabStop = true;
            this.freeRadioButton.Text = "Saatu ilmaiseksi";
            this.freeRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondhandPurchaseRadioButton
            // 
            this.secondhandPurchaseRadioButton.AutoSize = true;
            this.secondhandPurchaseRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondhandPurchaseRadioButton.Location = new System.Drawing.Point(7, 61);
            this.secondhandPurchaseRadioButton.Name = "secondhandPurchaseRadioButton";
            this.secondhandPurchaseRadioButton.Size = new System.Drawing.Size(130, 21);
            this.secondhandPurchaseRadioButton.TabIndex = 9;
            this.secondhandPurchaseRadioButton.TabStop = true;
            this.secondhandPurchaseRadioButton.Text = "Ostettu käytettynä";
            this.secondhandPurchaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // viewButton
            // 
            this.viewButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.Location = new System.Drawing.Point(32, 39);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(91, 37);
            this.viewButton.TabIndex = 10;
            this.viewButton.Text = "Katso listaa";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // viewTossedListRadioButton
            // 
            this.viewTossedListRadioButton.AutoSize = true;
            this.viewTossedListRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTossedListRadioButton.Location = new System.Drawing.Point(151, 39);
            this.viewTossedListRadioButton.Name = "viewTossedListRadioButton";
            this.viewTossedListRadioButton.Size = new System.Drawing.Size(99, 21);
            this.viewTossedListRadioButton.TabIndex = 11;
            this.viewTossedListRadioButton.TabStop = true;
            this.viewTossedListRadioButton.Text = "Siivotut asiat";
            this.viewTossedListRadioButton.UseVisualStyleBackColor = true;
            // 
            // viewAcquiredListRadioButton
            // 
            this.viewAcquiredListRadioButton.AutoSize = true;
            this.viewAcquiredListRadioButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAcquiredListRadioButton.Location = new System.Drawing.Point(151, 63);
            this.viewAcquiredListRadioButton.Name = "viewAcquiredListRadioButton";
            this.viewAcquiredListRadioButton.Size = new System.Drawing.Size(104, 21);
            this.viewAcquiredListRadioButton.TabIndex = 12;
            this.viewAcquiredListRadioButton.TabStop = true;
            this.viewAcquiredListRadioButton.Text = "Hankitut asiat";
            this.viewAcquiredListRadioButton.UseVisualStyleBackColor = true;
            // 
            // tossedTypeGroupBox
            // 
            this.tossedTypeGroupBox.Controls.Add(this.thrownAwayRadioButton);
            this.tossedTypeGroupBox.Controls.Add(this.charityRadioButton);
            this.tossedTypeGroupBox.Controls.Add(this.soldRadioButton);
            this.tossedTypeGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tossedTypeGroupBox.Location = new System.Drawing.Point(41, 137);
            this.tossedTypeGroupBox.Name = "tossedTypeGroupBox";
            this.tossedTypeGroupBox.Size = new System.Drawing.Size(146, 90);
            this.tossedTypeGroupBox.TabIndex = 13;
            this.tossedTypeGroupBox.TabStop = false;
            this.tossedTypeGroupBox.Text = "Mihin nakkasit?";
            // 
            // acquiredTypeGroupBox
            // 
            this.acquiredTypeGroupBox.Controls.Add(this.newPurchaseRadioButton);
            this.acquiredTypeGroupBox.Controls.Add(this.secondhandPurchaseRadioButton);
            this.acquiredTypeGroupBox.Controls.Add(this.freeRadioButton);
            this.acquiredTypeGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acquiredTypeGroupBox.Location = new System.Drawing.Point(217, 137);
            this.acquiredTypeGroupBox.Name = "acquiredTypeGroupBox";
            this.acquiredTypeGroupBox.Size = new System.Drawing.Size(146, 90);
            this.acquiredTypeGroupBox.TabIndex = 14;
            this.acquiredTypeGroupBox.TabStop = false;
            this.acquiredTypeGroupBox.Text = "Miten hankit?";
            // 
            // chooseViewGroupBox
            // 
            this.chooseViewGroupBox.Controls.Add(this.viewTossedListRadioButton);
            this.chooseViewGroupBox.Controls.Add(this.viewButton);
            this.chooseViewGroupBox.Controls.Add(this.viewAcquiredListRadioButton);
            this.chooseViewGroupBox.Location = new System.Drawing.Point(41, 259);
            this.chooseViewGroupBox.Name = "chooseViewGroupBox";
            this.chooseViewGroupBox.Size = new System.Drawing.Size(322, 111);
            this.chooseViewGroupBox.TabIndex = 15;
            this.chooseViewGroupBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(427, 411);
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

