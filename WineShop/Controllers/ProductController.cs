using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WineShop.Models;

namespace WineShop.Controllers
{
    public class ProductController : Controller
    {
        private DemoEntities de = new DemoEntities();
        
        // GET: Product
        public ActionResult Index()

        {
            ViewBag.ListProducts = de.Products.ToList();

            return View();
        }
    }
}