using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WineShop.Models;

namespace WineShop.Controllers
{
    public class ShopingCartController : Controller
     {
        private DemoEntities de = new DemoEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Quanty(int id)
        {

            if (Session["cart"]==null)
            {
                //List<Item> cart = new List<Item>();
                //cart.Add(new Item(de.Products.Find());

            }
            else
            {
                    
            }
          



            return View();
        }
    }
}