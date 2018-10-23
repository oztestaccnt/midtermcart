using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using HTMLHelpers.Models;


namespace MidTerm.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        //private List<Product> Products = new List<Product>()
        //{
        //    new Product {id = "100", Name = "Jeans", Price = 59.99},
        //    new Product {id = "101", Name = "Polo", Price = 49.99}
        //};

        public ActionResult DisplayProduct()
        {
            //ViewBag.ProductList = Products;

            ProductContext p = new ProductContext();
            var products = p.GetAll();

            return View(products);
        }

        public ActionResult ProcessOrder(FormCollection form)
        {
            List<Order> orders = new List<Order>();

            ProductContext productContext = new ProductContext();
            List<Product> products = productContext.GetAll();

            Int16 qty;
            foreach (var p in products)
            {
                if (Int16.TryParse(form[p.id], out qty) && qty > 0)
                {
                    orders.Add(new Order {Prod = p, Qty = qty});
                }

            }
            
            return View(orders);
        }


    }
}