using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Capstone.Models;

namespace Capstone.Models
{
    public class Item
    {

        public Item() { }

        public Item(Product product, int quantity)
        {
            this.pr = product;
            this.quantity = quantity;
        }

        private Product pr = new Product();
        private int quantity;
        
        public Product Pr
        {
            get { return pr; }
            set { pr = value; }
        }       

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}