
namespace WindowsFormsApp2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Total_Gas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.USD_Box = new System.Windows.Forms.TextBox();
            this.Liter_Box = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Price_Gas_Box = new System.Windows.Forms.TextBox();
            this.Price_Gas = new System.Windows.Forms.Label();
            this.Gas_Type = new System.Windows.Forms.ComboBox();
            this.Gas_Label = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Total_Cafe = new System.Windows.Forms.Label();
            this.Coke_Amount = new System.Windows.Forms.TextBox();
            this.Fries_Amount = new System.Windows.Forms.TextBox();
            this.Ham_Amount = new System.Windows.Forms.TextBox();
            this.Hot_Amount = new System.Windows.Forms.TextBox();
            this.Coke_Price = new System.Windows.Forms.TextBox();
            this.Fries_Price = new System.Windows.Forms.TextBox();
            this.Ham_Price = new System.Windows.Forms.TextBox();
            this.Hot_Price = new System.Windows.Forms.TextBox();
            this.Coke_Check = new System.Windows.Forms.CheckBox();
            this.Fries_Check = new System.Windows.Forms.CheckBox();
            this.Ham_Check = new System.Windows.Forms.CheckBox();
            this.Hot_Check = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.USD_Box);
            this.groupBox1.Controls.Add(this.Liter_Box);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.Price_Gas_Box);
            this.groupBox1.Controls.Add(this.Price_Gas);
            this.groupBox1.Controls.Add(this.Gas_Type);
            this.groupBox1.Controls.Add(this.Gas_Label);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 474);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gas Filling Station";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Total_Gas);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(9, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 152);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Amount_Payable";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "USD";
            // 
            // Total_Gas
            // 
            this.Total_Gas.AutoSize = true;
            this.Total_Gas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Gas.Location = new System.Drawing.Point(33, 64);
            this.Total_Gas.Name = "Total_Gas";
            this.Total_Gas.Size = new System.Drawing.Size(49, 24);
            this.Total_Gas.TabIndex = 0;
            this.Total_Gas.Text = "0.00";
            this.Total_Gas.TextChanged += new System.EventHandler(this.Total_Gas_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "USD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Liters";
            // 
            // USD_Box
            // 
            this.USD_Box.Location = new System.Drawing.Point(141, 142);
            this.USD_Box.Name = "USD_Box";
            this.USD_Box.Size = new System.Drawing.Size(100, 20);
            this.USD_Box.TabIndex = 7;
            this.USD_Box.TextChanged += new System.EventHandler(this.USD_Box_TextChanged);
            // 
            // Liter_Box
            // 
            this.Liter_Box.Location = new System.Drawing.Point(141, 107);
            this.Liter_Box.Name = "Liter_Box";
            this.Liter_Box.Size = new System.Drawing.Size(100, 20);
            this.Liter_Box.TabIndex = 6;
            this.Liter_Box.TextChanged += new System.EventHandler(this.Liter_Box_TextChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 144);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(99, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "Amount ( USD )";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 109);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Amount ( Liters )";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Price_Gas_Box
            // 
            this.Price_Gas_Box.Location = new System.Drawing.Point(54, 61);
            this.Price_Gas_Box.Name = "Price_Gas_Box";
            this.Price_Gas_Box.Size = new System.Drawing.Size(95, 20);
            this.Price_Gas_Box.TabIndex = 3;
            // 
            // Price_Gas
            // 
            this.Price_Gas.AutoSize = true;
            this.Price_Gas.Location = new System.Drawing.Point(6, 64);
            this.Price_Gas.Name = "Price_Gas";
            this.Price_Gas.Size = new System.Drawing.Size(31, 13);
            this.Price_Gas.TabIndex = 2;
            this.Price_Gas.Text = "Price";
            // 
            // Gas_Type
            // 
            this.Gas_Type.FormattingEnabled = true;
            this.Gas_Type.Location = new System.Drawing.Point(54, 23);
            this.Gas_Type.Name = "Gas_Type";
            this.Gas_Type.Size = new System.Drawing.Size(121, 21);
            this.Gas_Type.TabIndex = 1;
            this.Gas_Type.SelectedIndexChanged += new System.EventHandler(this.Gas_Type_SelectedIndexChanged);
            // 
            // Gas_Label
            // 
            this.Gas_Label.AutoSize = true;
            this.Gas_Label.Location = new System.Drawing.Point(6, 27);
            this.Gas_Label.Name = "Gas_Label";
            this.Gas_Label.Size = new System.Drawing.Size(29, 13);
            this.Gas_Label.TabIndex = 0;
            this.Gas_Label.Text = "Gas ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.Coke_Amount);
            this.groupBox3.Controls.Add(this.Fries_Amount);
            this.groupBox3.Controls.Add(this.Ham_Amount);
            this.groupBox3.Controls.Add(this.Hot_Amount);
            this.groupBox3.Controls.Add(this.Coke_Price);
            this.groupBox3.Controls.Add(this.Fries_Price);
            this.groupBox3.Controls.Add(this.Ham_Price);
            this.groupBox3.Controls.Add(this.Hot_Price);
            this.groupBox3.Controls.Add(this.Coke_Check);
            this.groupBox3.Controls.Add(this.Fries_Check);
            this.groupBox3.Controls.Add(this.Ham_Check);
            this.groupBox3.Controls.Add(this.Hot_Check);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(433, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 474);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mini Cafe";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.Total_Cafe);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox4.Location = new System.Drawing.Point(7, 209);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(347, 152);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Amount_Payable";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "USD";
            // 
            // Total_Cafe
            // 
            this.Total_Cafe.AutoSize = true;
            this.Total_Cafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Cafe.Location = new System.Drawing.Point(25, 64);
            this.Total_Cafe.Name = "Total_Cafe";
            this.Total_Cafe.Size = new System.Drawing.Size(49, 24);
            this.Total_Cafe.TabIndex = 0;
            this.Total_Cafe.Text = "0.00";
            this.Total_Cafe.TextChanged += new System.EventHandler(this.Total_Cafe_TextChanged);
            // 
            // Coke_Amount
            // 
            this.Coke_Amount.Location = new System.Drawing.Point(254, 102);
            this.Coke_Amount.Name = "Coke_Amount";
            this.Coke_Amount.Size = new System.Drawing.Size(100, 20);
            this.Coke_Amount.TabIndex = 11;
            this.Coke_Amount.TextChanged += new System.EventHandler(this.Hot_Amount_TextChanged);
            // 
            // Fries_Amount
            // 
            this.Fries_Amount.Location = new System.Drawing.Point(254, 77);
            this.Fries_Amount.Name = "Fries_Amount";
            this.Fries_Amount.Size = new System.Drawing.Size(100, 20);
            this.Fries_Amount.TabIndex = 10;
            this.Fries_Amount.TextChanged += new System.EventHandler(this.Hot_Amount_TextChanged);
            // 
            // Ham_Amount
            // 
            this.Ham_Amount.Location = new System.Drawing.Point(254, 51);
            this.Ham_Amount.Name = "Ham_Amount";
            this.Ham_Amount.Size = new System.Drawing.Size(100, 20);
            this.Ham_Amount.TabIndex = 9;
            this.Ham_Amount.TextChanged += new System.EventHandler(this.Hot_Amount_TextChanged);
            // 
            // Hot_Amount
            // 
            this.Hot_Amount.Location = new System.Drawing.Point(254, 25);
            this.Hot_Amount.Name = "Hot_Amount";
            this.Hot_Amount.Size = new System.Drawing.Size(100, 20);
            this.Hot_Amount.TabIndex = 8;
            this.Hot_Amount.TextChanged += new System.EventHandler(this.Hot_Amount_TextChanged);
            // 
            // Coke_Price
            // 
            this.Coke_Price.Location = new System.Drawing.Point(118, 103);
            this.Coke_Price.Name = "Coke_Price";
            this.Coke_Price.Size = new System.Drawing.Size(100, 20);
            this.Coke_Price.TabIndex = 7;
            // 
            // Fries_Price
            // 
            this.Fries_Price.Location = new System.Drawing.Point(118, 77);
            this.Fries_Price.Name = "Fries_Price";
            this.Fries_Price.Size = new System.Drawing.Size(100, 20);
            this.Fries_Price.TabIndex = 6;
            // 
            // Ham_Price
            // 
            this.Ham_Price.Location = new System.Drawing.Point(118, 51);
            this.Ham_Price.Name = "Ham_Price";
            this.Ham_Price.Size = new System.Drawing.Size(100, 20);
            this.Ham_Price.TabIndex = 5;
            // 
            // Hot_Price
            // 
            this.Hot_Price.Location = new System.Drawing.Point(118, 25);
            this.Hot_Price.Name = "Hot_Price";
            this.Hot_Price.Size = new System.Drawing.Size(100, 20);
            this.Hot_Price.TabIndex = 4;
            // 
            // Coke_Check
            // 
            this.Coke_Check.AutoSize = true;
            this.Coke_Check.Location = new System.Drawing.Point(6, 107);
            this.Coke_Check.Name = "Coke_Check";
            this.Coke_Check.Size = new System.Drawing.Size(75, 17);
            this.Coke_Check.TabIndex = 3;
            this.Coke_Check.Text = "Coca-Cola";
            this.Coke_Check.UseVisualStyleBackColor = true;
            this.Coke_Check.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Fries_Check
            // 
            this.Fries_Check.AutoSize = true;
            this.Fries_Check.Location = new System.Drawing.Point(6, 82);
            this.Fries_Check.Name = "Fries_Check";
            this.Fries_Check.Size = new System.Drawing.Size(84, 17);
            this.Fries_Check.TabIndex = 2;
            this.Fries_Check.Text = "French Fries";
            this.Fries_Check.UseVisualStyleBackColor = true;
            this.Fries_Check.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Ham_Check
            // 
            this.Ham_Check.AutoSize = true;
            this.Ham_Check.Location = new System.Drawing.Point(6, 54);
            this.Ham_Check.Name = "Ham_Check";
            this.Ham_Check.Size = new System.Drawing.Size(78, 17);
            this.Ham_Check.TabIndex = 1;
            this.Ham_Check.Text = "Hamburger";
            this.Ham_Check.UseVisualStyleBackColor = true;
            this.Ham_Check.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Hot_Check
            // 
            this.Hot_Check.AutoSize = true;
            this.Hot_Check.Location = new System.Drawing.Point(6, 28);
            this.Hot_Check.Name = "Hot_Check";
            this.Hot_Check.Size = new System.Drawing.Size(66, 17);
            this.Hot_Check.TabIndex = 0;
            this.Hot_Check.Text = "Hot-Dog";
            this.Hot_Check.UseVisualStyleBackColor = true;
            this.Hot_Check.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.Total);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox5.Location = new System.Drawing.Point(13, 494);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(795, 188);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total_Amount_Payable";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(641, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "USD";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(434, 85);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(58, 25);
            this.Total.TabIndex = 0;
            this.Total.Text = "0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 704);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Price_Gas_Box;
        private System.Windows.Forms.Label Price_Gas;
        private System.Windows.Forms.ComboBox Gas_Type;
        private System.Windows.Forms.Label Gas_Label;
        private System.Windows.Forms.TextBox USD_Box;
        private System.Windows.Forms.TextBox Liter_Box;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Total_Gas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Coke_Amount;
        private System.Windows.Forms.TextBox Fries_Amount;
        private System.Windows.Forms.TextBox Ham_Amount;
        private System.Windows.Forms.TextBox Hot_Amount;
        private System.Windows.Forms.TextBox Coke_Price;
        private System.Windows.Forms.TextBox Fries_Price;
        private System.Windows.Forms.TextBox Ham_Price;
        private System.Windows.Forms.TextBox Hot_Price;
        private System.Windows.Forms.CheckBox Coke_Check;
        private System.Windows.Forms.CheckBox Fries_Check;
        private System.Windows.Forms.CheckBox Ham_Check;
        private System.Windows.Forms.CheckBox Hot_Check;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Total_Cafe;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Total;
    }
}

