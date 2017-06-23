using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WineShop.Models;

namespace WineShop.Controllers
{
    public class Item
    {
        private Product product = new Product();
        private int quantity;

        public Item()
        {
        }

        public Item(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }
    }
}