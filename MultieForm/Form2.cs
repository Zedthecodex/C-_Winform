using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultieForm
{
    public partial class Form2 : Form
    {
        Product t;
        bool addnew;
        public Form2(Product t, bool addnew)
        {
            InitializeComponent();
            this.addnew = addnew;
            this.t = t; // Remember the reference to the product
            if (addnew == false)
            {
                /* if the form opens for editing, then firstly
                input information about the product being chainged to text fiels */

                textBox1.Text = t.Name;
                textBox2.Text = t.Made_in;
                textBox3.Text = t.Price.ToString();
                this.Text = "Product Editing"; // Change the Header
            }
            //Change the Header if Creating a product 
            else this.Text = "Adding a Product ";
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text  == "" || textBox2.Text == "" || textBox3.Text =="")
            {
                //Validating of filling in the fields
                MessageBox.Show("Fill in all the fiels");
                return;
            }

            if( t==null)
            
                t = new Product();
                t.Name = textBox1.Text;
                t.Made_in = textBox2.Text;

                try
                {
                    /*When Converting from a string to a real number, an error will occur
                    if the string is of incorrect format */

                    t.Price = Convert.ToDouble(textBox3.Text);
                }
                catch
                {
                    MessageBox.Show("Wrong Price");
                }
                this.DialogResult = DialogResult.OK;
            

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }



       

        
    }
}
