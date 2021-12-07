using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MiniCafeSetup();


            Gas_Type.Items.Add(new Gas_Count("Normal", 1.03m));
            Gas_Type.Items.Add(new Gas_Count("Super", 1.53m));
            Gas_Type.Items.Add(new Gas_Count("Gas", 0.634m));
        }

        private void Gas_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Price_Gas_Box.Enabled = false;
            Gas_Count selectedItem = (Gas_Count)Gas_Type.SelectedItem;
            decimal Price_liter = selectedItem.Price_gas;

            Price_Gas_Box.Text = Price_liter.ToString();
        }


        public class Gas_Count
        {
            private readonly string name;
            public string Name
            {
                get { return this.name; }

            }

            private readonly decimal price;
            public decimal Price_gas
            {
                get { return this.price; }
            }

            public Gas_Count(string name, decimal price)
            {
                this.name = name;
                this.price = price;
            }

            public override string ToString()
            {
                return this.name;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                Liter_Box.Enabled = true;
                USD_Box.Enabled = false;
            }
            else
            {
                Liter_Box.Enabled = false;
                USD_Box.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Hot_Amount.Enabled = Hot_Check.Checked;
            Ham_Amount.Enabled = Ham_Check.Checked;
            Fries_Amount.Enabled = Fries_Check.Checked;
            Coke_Amount.Enabled = Coke_Check.Checked;
        }

        private void Liter_Box_TextChanged(object sender, EventArgs e)
        {
            CalculateFillingPrice();
        }

        private void USD_Box_TextChanged(object sender, EventArgs e)
        {
            CalculateFillingPrice();
        }
        private void Hot_Amount_TextChanged(object sender, EventArgs e)
        {
            CalculateCafePrice();
        }

        private void Total_Gas_TextChanged(object sender, EventArgs e)
        {
            decimal Total_price = 0.00m;

            Total_price = decimal.Parse(Total_Cafe.Text) + decimal.Parse(Total_Gas.Text);

            Total.Text = Total_price.ToString();

        }

        private void Total_Cafe_TextChanged(object sender, EventArgs e)
        {
            decimal Total_price = 0.00m;

            Total_price = decimal.Parse(Total_Gas.Text) + decimal.Parse(Total_Cafe.Text);

            Total.Text = Total_price.ToString();
        }

        public void CalculateFillingPrice()
        {
            decimal price = 0.00m;
            try
            {
                if (radioButton1.Checked)
                {
                    price = decimal.Parse(Liter_Box.Text) * decimal.Parse(Price_Gas_Box.Text);
                }
                else
                {
                    price = decimal.Parse(USD_Box.Text);
                }

            }
            catch { }
            Total_Gas.Text = price.ToString();
        }

        public void CalculateCafePrice()
        {
            decimal price = 0.00m;

            if(Hot_Check.Checked)
            {
                try
                {
                    price += decimal.Parse(Hot_Price.Text) * decimal.Parse(Hot_Amount.Text);
                }
                catch { }
            }

            if (Ham_Check.Checked)
            {
                try
                {
                    price += decimal.Parse(Ham_Price.Text) * decimal.Parse(Ham_Amount.Text);
                }
                catch { }
            }

            if (Fries_Check.Checked)
            {
                try
                {
                    price += decimal.Parse(Fries_Price.Text) * decimal.Parse(Fries_Amount.Text);
                }
                catch { }
            }

            if (Coke_Check.Checked)
            {
                try
                {
                    price += decimal.Parse(Coke_Price.Text) * decimal.Parse(Coke_Amount.Text);
                }
                catch { }
            }
            decimal cafe_price = price;
            Total_Cafe.Text = cafe_price.ToString();
        }
        private void MiniCafeSetup()
        {
            Hot_Price.Text = "3.00";
            Ham_Price.Text = "4.50";
            Fries_Price.Text = "1.50";
            Coke_Price.Text = "0.70";

            Hot_Price.Enabled = false;
            Hot_Amount.Enabled = false;
            Ham_Price.Enabled = false;
            Ham_Amount.Enabled = false;
            Fries_Price.Enabled = false;
            Fries_Amount.Enabled = false;
            Coke_Price.Enabled = false;
            Coke_Amount.Enabled = false;
        }

       
    }
}
