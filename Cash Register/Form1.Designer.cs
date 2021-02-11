namespace Cash_Register
{
    partial class Form1
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
            this.storeTitle = new System.Windows.Forms.Label();
            this.burgerLabel = new System.Windows.Forms.Label();
            this.sliderLabel = new System.Windows.Forms.Label();
            this.juiceLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.totalsButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.receiptButton = new System.Windows.Forms.Button();
            this.tenderedTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.taxAmountLabel = new System.Windows.Forms.Label();
            this.totalAmountLabel = new System.Windows.Forms.Label();
            this.changeAmountLabel = new System.Windows.Forms.Label();
            this.receiptTitleLabel = new System.Windows.Forms.Label();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.itemPriceLabel = new System.Windows.Forms.Label();
            this.receiptTaxLabel = new System.Windows.Forms.Label();
            this.receiptTaxAmount = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedAmount = new System.Windows.Forms.Label();
            this.niceDayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // storeTitle
            // 
            this.storeTitle.BackColor = System.Drawing.Color.LightBlue;
            this.storeTitle.Font = new System.Drawing.Font("Amelia BT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeTitle.Location = new System.Drawing.Point(-2, -2);
            this.storeTitle.Name = "storeTitle";
            this.storeTitle.Size = new System.Drawing.Size(706, 88);
            this.storeTitle.TabIndex = 0;
            this.storeTitle.Text = "Bill\'s Burger\'s";
            this.storeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.storeTitle.Click += new System.EventHandler(this.Label1_Click);
            // 
            // burgerLabel
            // 
            this.burgerLabel.AutoSize = true;
            this.burgerLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerLabel.Location = new System.Drawing.Point(42, 99);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(127, 16);
            this.burgerLabel.TabIndex = 1;
            this.burgerLabel.Text = "Number of Burgers";
            // 
            // sliderLabel
            // 
            this.sliderLabel.AutoSize = true;
            this.sliderLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sliderLabel.Location = new System.Drawing.Point(42, 127);
            this.sliderLabel.Name = "sliderLabel";
            this.sliderLabel.Size = new System.Drawing.Size(122, 16);
            this.sliderLabel.TabIndex = 2;
            this.sliderLabel.Text = "Number of Sliders";
            // 
            // juiceLabel
            // 
            this.juiceLabel.AutoSize = true;
            this.juiceLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juiceLabel.Location = new System.Drawing.Point(42, 161);
            this.juiceLabel.Name = "juiceLabel";
            this.juiceLabel.Size = new System.Drawing.Size(159, 16);
            this.juiceLabel.TabIndex = 3;
            this.juiceLabel.Text = "Number of Burger Juice";
            this.juiceLabel.Click += new System.EventHandler(this.JuiceLabel_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(236, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(56, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(236, 121);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(56, 22);
            this.textBox4.TabIndex = 7;
            this.textBox4.TextChanged += new System.EventHandler(this.TextBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(236, 155);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(56, 22);
            this.textBox5.TabIndex = 8;
            // 
            // totalsButton
            // 
            this.totalsButton.Location = new System.Drawing.Point(69, 197);
            this.totalsButton.Name = "totalsButton";
            this.totalsButton.Size = new System.Drawing.Size(205, 23);
            this.totalsButton.TabIndex = 9;
            this.totalsButton.Text = "Calculate Totals";
            this.totalsButton.UseVisualStyleBackColor = true;
            this.totalsButton.Click += new System.EventHandler(this.TotalsButton_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.Location = new System.Drawing.Point(42, 245);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(68, 16);
            this.subTotalLabel.TabIndex = 10;
            this.subTotalLabel.Text = "Sub Total";
            this.subTotalLabel.Click += new System.EventHandler(this.SubTotalLabel_Click);
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(42, 276);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(31, 16);
            this.taxLabel.TabIndex = 11;
            this.taxLabel.Text = "Tax";
            // 
            // totalButton
            // 
            this.totalButton.AutoSize = true;
            this.totalButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.Location = new System.Drawing.Point(42, 309);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(39, 16);
            this.totalButton.TabIndex = 12;
            this.totalButton.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tendered";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(42, 393);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(57, 16);
            this.changeLabel.TabIndex = 14;
            this.changeLabel.Text = "Change";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(69, 367);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(205, 23);
            this.changeButton.TabIndex = 15;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // receiptButton
            // 
            this.receiptButton.Location = new System.Drawing.Point(69, 415);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(205, 23);
            this.receiptButton.TabIndex = 16;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.ReceiptButton_Click);
            // 
            // tenderedTextbox
            // 
            this.tenderedTextbox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tenderedTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedTextbox.Location = new System.Drawing.Point(130, 342);
            this.tenderedTextbox.Name = "tenderedTextbox";
            this.tenderedTextbox.Size = new System.Drawing.Size(56, 22);
            this.tenderedTextbox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 10);
            this.label1.TabIndex = 18;
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.receiptLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.receiptLabel.Location = new System.Drawing.Point(342, 93);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(317, 320);
            this.receiptLabel.TabIndex = 19;
            // 
            // subLabel
            // 
            this.subLabel.Location = new System.Drawing.Point(192, 245);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(100, 23);
            this.subLabel.TabIndex = 20;
            this.subLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxAmountLabel
            // 
            this.taxAmountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.taxAmountLabel.Location = new System.Drawing.Point(192, 269);
            this.taxAmountLabel.Name = "taxAmountLabel";
            this.taxAmountLabel.Size = new System.Drawing.Size(100, 23);
            this.taxAmountLabel.TabIndex = 21;
            this.taxAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalAmountLabel
            // 
            this.totalAmountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalAmountLabel.Location = new System.Drawing.Point(192, 302);
            this.totalAmountLabel.Name = "totalAmountLabel";
            this.totalAmountLabel.Size = new System.Drawing.Size(100, 23);
            this.totalAmountLabel.TabIndex = 22;
            this.totalAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // changeAmountLabel
            // 
            this.changeAmountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.changeAmountLabel.Location = new System.Drawing.Point(192, 390);
            this.changeAmountLabel.Name = "changeAmountLabel";
            this.changeAmountLabel.Size = new System.Drawing.Size(100, 23);
            this.changeAmountLabel.TabIndex = 23;
            this.changeAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // receiptTitleLabel
            // 
            this.receiptTitleLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.receiptTitleLabel.Location = new System.Drawing.Point(414, 121);
            this.receiptTitleLabel.Name = "receiptTitleLabel";
            this.receiptTitleLabel.Size = new System.Drawing.Size(169, 23);
            this.receiptTitleLabel.TabIndex = 24;
            this.receiptTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.itemsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.itemsLabel.Location = new System.Drawing.Point(377, 173);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(0, 13);
            this.itemsLabel.TabIndex = 25;
            this.itemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // itemPriceLabel
            // 
            this.itemPriceLabel.AutoSize = true;
            this.itemPriceLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.itemPriceLabel.Location = new System.Drawing.Point(568, 173);
            this.itemPriceLabel.Name = "itemPriceLabel";
            this.itemPriceLabel.Size = new System.Drawing.Size(0, 13);
            this.itemPriceLabel.TabIndex = 26;
            this.itemPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // receiptTaxLabel
            // 
            this.receiptTaxLabel.AutoSize = true;
            this.receiptTaxLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.receiptTaxLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.receiptTaxLabel.Location = new System.Drawing.Point(377, 248);
            this.receiptTaxLabel.Name = "receiptTaxLabel";
            this.receiptTaxLabel.Size = new System.Drawing.Size(0, 13);
            this.receiptTaxLabel.TabIndex = 27;
            this.receiptTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // receiptTaxAmount
            // 
            this.receiptTaxAmount.AutoSize = true;
            this.receiptTaxAmount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.receiptTaxAmount.Location = new System.Drawing.Point(568, 245);
            this.receiptTaxAmount.Name = "receiptTaxAmount";
            this.receiptTaxAmount.Size = new System.Drawing.Size(0, 13);
            this.receiptTaxAmount.TabIndex = 29;
            this.receiptTaxAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tenderedLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tenderedLabel.Location = new System.Drawing.Point(377, 312);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(0, 13);
            this.tenderedLabel.TabIndex = 30;
            this.tenderedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tenderedAmount
            // 
            this.tenderedAmount.AutoSize = true;
            this.tenderedAmount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tenderedAmount.Location = new System.Drawing.Point(568, 312);
            this.tenderedAmount.Name = "tenderedAmount";
            this.tenderedAmount.Size = new System.Drawing.Size(0, 13);
            this.tenderedAmount.TabIndex = 31;
            this.tenderedAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // niceDayLabel
            // 
            this.niceDayLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.niceDayLabel.Location = new System.Drawing.Point(449, 367);
            this.niceDayLabel.Name = "niceDayLabel";
            this.niceDayLabel.Size = new System.Drawing.Size(100, 23);
            this.niceDayLabel.TabIndex = 32;
            this.niceDayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.niceDayLabel);
            this.Controls.Add(this.tenderedAmount);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.receiptTaxAmount);
            this.Controls.Add(this.receiptTaxLabel);
            this.Controls.Add(this.itemPriceLabel);
            this.Controls.Add(this.itemsLabel);
            this.Controls.Add(this.receiptTitleLabel);
            this.Controls.Add(this.changeAmountLabel);
            this.Controls.Add(this.totalAmountLabel);
            this.Controls.Add(this.taxAmountLabel);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tenderedTextbox);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.totalsButton);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.juiceLabel);
            this.Controls.Add(this.sliderLabel);
            this.Controls.Add(this.burgerLabel);
            this.Controls.Add(this.storeTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label storeTitle;
        private System.Windows.Forms.Label burgerLabel;
        private System.Windows.Forms.Label sliderLabel;
        private System.Windows.Forms.Label juiceLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button totalsButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.TextBox tenderedTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.Label taxAmountLabel;
        private System.Windows.Forms.Label totalAmountLabel;
        private System.Windows.Forms.Label changeAmountLabel;
        private System.Windows.Forms.Label receiptTitleLabel;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.Label itemPriceLabel;
        private System.Windows.Forms.Label receiptTaxLabel;
        private System.Windows.Forms.Label receiptTaxAmount;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label tenderedAmount;
        private System.Windows.Forms.Label niceDayLabel;
    }
}

