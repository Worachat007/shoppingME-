namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cf_Price = new TextBox();
            label1 = new Label();
            label2 = new Label();
            gt_Price = new TextBox();
            checkCoffee = new CheckBox();
            checkGreentea = new CheckBox();
            gt_Quantity = new TextBox();
            cf_Quantity = new TextBox();
            tbCash = new TextBox();
            button1 = new Button();
            FiveHundred = new TextBox();
            OneThousand = new TextBox();
            tbChange = new TextBox();
            Twenty = new TextBox();
            Fifty = new TextBox();
            OneHundred = new TextBox();
            button2 = new Button();
            tbTotai = new TextBox();
            label3 = new Label();
            Price = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            Five = new TextBox();
            Ten = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            One = new TextBox();
            label15 = new Label();
            SuspendLayout();
            // 
            // cf_Price
            // 
            cf_Price.Location = new Point(211, 72);
            cf_Price.Name = "cf_Price";
            cf_Price.Size = new Size(125, 27);
            cf_Price.TabIndex = 0;
            cf_Price.Text = "0";
            cf_Price.TextChanged += cf_Price_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 82);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 133);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // gt_Price
            // 
            gt_Price.Location = new Point(211, 126);
            gt_Price.Name = "gt_Price";
            gt_Price.Size = new Size(125, 27);
            gt_Price.TabIndex = 3;
            gt_Price.Text = "0";
            // 
            // checkCoffee
            // 
            checkCoffee.AutoSize = true;
            checkCoffee.BackColor = SystemColors.Control;
            checkCoffee.Location = new Point(74, 72);
            checkCoffee.Name = "checkCoffee";
            checkCoffee.Size = new Size(75, 24);
            checkCoffee.TabIndex = 4;
            checkCoffee.Text = "Coffee";
            checkCoffee.UseVisualStyleBackColor = false;
            checkCoffee.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkGreentea
            // 
            checkGreentea.AutoSize = true;
            checkGreentea.Location = new Point(74, 131);
            checkGreentea.Name = "checkGreentea";
            checkGreentea.Size = new Size(95, 24);
            checkGreentea.TabIndex = 5;
            checkGreentea.Text = "Green tea";
            checkGreentea.UseVisualStyleBackColor = true;
            // 
            // gt_Quantity
            // 
            gt_Quantity.Location = new Point(368, 126);
            gt_Quantity.Name = "gt_Quantity";
            gt_Quantity.Size = new Size(125, 27);
            gt_Quantity.TabIndex = 7;
            gt_Quantity.Text = "0";
            // 
            // cf_Quantity
            // 
            cf_Quantity.Location = new Point(368, 72);
            cf_Quantity.Name = "cf_Quantity";
            cf_Quantity.Size = new Size(125, 27);
            cf_Quantity.TabIndex = 6;
            cf_Quantity.Text = "0";
            // 
            // tbCash
            // 
            tbCash.Location = new Point(660, 120);
            tbCash.Name = "tbCash";
            tbCash.Size = new Size(125, 27);
            tbCash.TabIndex = 8;
            tbCash.TextChanged += textBox6_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(241, 246);
            button1.Name = "button1";
            button1.Size = new Size(194, 117);
            button1.TabIndex = 9;
            button1.Text = "Check Out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FiveHundred
            // 
            FiveHundred.Location = new Point(660, 291);
            FiveHundred.Name = "FiveHundred";
            FiveHundred.Size = new Size(125, 27);
            FiveHundred.TabIndex = 12;
            FiveHundred.TextChanged += textBox5_TextChanged;
            // 
            // OneThousand
            // 
            OneThousand.Location = new Point(660, 258);
            OneThousand.Name = "OneThousand";
            OneThousand.Size = new Size(125, 27);
            OneThousand.TabIndex = 11;
            // 
            // tbChange
            // 
            tbChange.Location = new Point(660, 225);
            tbChange.Name = "tbChange";
            tbChange.Size = new Size(125, 27);
            tbChange.TabIndex = 10;
            // 
            // Twenty
            // 
            Twenty.Location = new Point(660, 390);
            Twenty.Name = "Twenty";
            Twenty.Size = new Size(125, 27);
            Twenty.TabIndex = 15;
            // 
            // Fifty
            // 
            Fifty.Location = new Point(660, 357);
            Fifty.Name = "Fifty";
            Fifty.Size = new Size(125, 27);
            Fifty.TabIndex = 14;
            // 
            // OneHundred
            // 
            OneHundred.Location = new Point(660, 324);
            OneHundred.Name = "OneHundred";
            OneHundred.Size = new Size(125, 27);
            OneHundred.TabIndex = 13;
            // 
            // button2
            // 
            button2.Location = new Point(633, 171);
            button2.Name = "button2";
            button2.Size = new Size(193, 32);
            button2.TabIndex = 16;
            button2.Text = "Change Detaills";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tbTotai
            // 
            tbTotai.Location = new Point(660, 66);
            tbTotai.Name = "tbTotai";
            tbTotai.Size = new Size(125, 27);
            tbTotai.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 18;
            label3.Text = "label3";
            // 
            // Price
            // 
            Price.AutoSize = true;
            Price.Location = new Point(251, 24);
            Price.Name = "Price";
            Price.Size = new Size(41, 20);
            Price.TabIndex = 19;
            Price.Text = "Price";
            Price.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(391, 24);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 20;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(573, 69);
            label6.Name = "label6";
            label6.Size = new Size(43, 20);
            label6.TabIndex = 21;
            label6.Text = "Totai";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(573, 126);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 22;
            label7.Text = "Cash";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(573, 258);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 24;
            label4.Text = "1000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(573, 225);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 23;
            label8.Text = "Change";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(573, 324);
            label9.Name = "label9";
            label9.Size = new Size(33, 20);
            label9.TabIndex = 26;
            label9.Text = "100";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(573, 291);
            label10.Name = "label10";
            label10.Size = new Size(33, 20);
            label10.TabIndex = 25;
            label10.Text = "500";
            // 
            // Five
            // 
            Five.Location = new Point(660, 456);
            Five.Name = "Five";
            Five.Size = new Size(125, 27);
            Five.TabIndex = 28;
            // 
            // Ten
            // 
            Ten.Location = new Point(660, 423);
            Ten.Name = "Ten";
            Ten.Size = new Size(125, 27);
            Ten.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(573, 456);
            label11.Name = "label11";
            label11.Size = new Size(17, 20);
            label11.TabIndex = 32;
            label11.Text = "5";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(573, 418);
            label12.Name = "label12";
            label12.Size = new Size(25, 20);
            label12.TabIndex = 31;
            label12.Text = "10";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(573, 385);
            label13.Name = "label13";
            label13.Size = new Size(25, 20);
            label13.TabIndex = 30;
            label13.Text = "20";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(573, 352);
            label14.Name = "label14";
            label14.Size = new Size(25, 20);
            label14.TabIndex = 29;
            label14.Text = "50";
            // 
            // One
            // 
            One.Location = new Point(660, 489);
            One.Name = "One";
            One.Size = new Size(125, 27);
            One.TabIndex = 33;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(573, 489);
            label15.Name = "label15";
            label15.Size = new Size(17, 20);
            label15.TabIndex = 34;
            label15.Text = "1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 580);
            Controls.Add(label15);
            Controls.Add(One);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(Five);
            Controls.Add(Ten);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Price);
            Controls.Add(label3);
            Controls.Add(tbTotai);
            Controls.Add(button2);
            Controls.Add(Twenty);
            Controls.Add(Fifty);
            Controls.Add(OneHundred);
            Controls.Add(FiveHundred);
            Controls.Add(OneThousand);
            Controls.Add(tbChange);
            Controls.Add(button1);
            Controls.Add(tbCash);
            Controls.Add(gt_Quantity);
            Controls.Add(cf_Quantity);
            Controls.Add(checkGreentea);
            Controls.Add(checkCoffee);
            Controls.Add(gt_Price);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cf_Price);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox cf_Price;
        private Label label1;
        private Label label2;
        private TextBox gt_Price;
        private CheckBox checkCoffee;
        private CheckBox checkGreentea;
        private TextBox gt_Quantity;
        private TextBox cf_Quantity;
        private TextBox tbCash;
        private Button button1;
        private TextBox FiveHundred;
        private TextBox OneThousand;
        private TextBox tbChange;
        private TextBox Twenty;
        private TextBox Fifty;
        private TextBox OneHundred;
        private Button button2;
        private TextBox tbTotai;
        private Label label3;
        private Label Price;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox Five;
        private TextBox Ten;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox One;
        private Label label15;
    }
}
