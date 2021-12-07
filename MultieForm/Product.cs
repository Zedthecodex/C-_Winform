using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultieForm
{
    public class Product
    {
        string name; // Product name
        string made_in; //Country of Origin
        double price; // Price

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Made_in
        {
            get { return made_in; }
            set { made_in = value; }

        }

        public double Price
        {
            get { return price; }
            set
            {
                if (price < 0)
                    throw new System.Exception("The Price can not be less than Zero");
                price = value;
            }
        }

        public Product()
        {
            Name = "Unknown";
            Price = 0;
            Made_in = "Unknown";
        }

        public Product(string name, string made, double price)
        {
            Name = name;
            Made_in = made;
            Price = price;
        }

        public override string ToString()
        {
            return Name + " -Manufacturer : " + Made_in + " Price : " + Price;

        }

    }
}
