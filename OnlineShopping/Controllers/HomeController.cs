using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OnlineShopping.Models;

namespace OnlineShopping.Controllers
{
    public class HomeController : Controller
    {
        private ShopDBEntities db = new ShopDBEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Admin()
        {
            return View();
        }

        public ActionResult Products()

        {  
            ProductModel p = new ProductModel();
            p.Cat = db.Categories.ToList();
            p.Pro = db.Products.ToList();
            return View(p);
        }

    }
}