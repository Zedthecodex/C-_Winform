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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Form2 form = null;

        private void ClearAll_Click(object sender, EventArgs e)
        {//Clear the Whoel List
            listBox1.Items.Clear();
        }

        private void DeleteGood_Click(object sender, EventArgs e)
        {//Deleting the Selected Item 
            if(listBox1.SelectedIndex == -1) // No product selected
            {
                MessageBox.Show("You have not selected any products");
                return;
            }
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);

        }
        Product t = null;

        private void AddGood_Click(object sender, EventArgs e)
        { //Adding a Product
            t = new Product();
            Form2 addform = new Form2(t, true);
            if (addform.ShowDialog() == DialogResult.OK)
            {//If the used has clicked OK, add a product
                listBox1.Items.Add(t);
            }
        }

        private void EditGood_Click(object sender, EventArgs e)
        {//Editing a Product
            if( listBox1.SelectedIndex == -1 ) // If a product is not selected
            {
                MessageBox.Show("You have not selected a Product");
                return;
            }
            int n = listBox1.SelectedIndex; //Remeber the item selected

            //Take a reference to the selected item
            t = (Product)listBox1.Items[n];
            Form2 editform = new Form2(t, false);
            editform.ShowDialog();
            listBox1.Items.RemoveAt(n); //Delete the item selected and add at same place
            // in order to redraw it in the list
            listBox1.Items.Insert(n, t);
            listBox1.SelectedIndex = n; // Select this item again
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
