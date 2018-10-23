using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using HTMLHelpers.Models;

namespace HTMLHelpers.Models
{
    
    public class Product
    {
        public string id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string CustName { get; set; }
        public string CustAddress { get; set; }


        [Required]
        [Range(1, 50)]
        public int Qty { get; set; }
    }


    //public class Category
    //{
    //    public string Id { get; set; }
    //    // and more properties
    //}


    public class ProductContext
    {

        //public Product Product { get; set; }

        public List<Product> GetAll()

        {
            return new List<Product>()
            {
                new Product {id = "100", Name = "Jeans", Price = 59.99},
                new Product {id = "101", Name = "Polo", Price = 49.99},
                new Product {id = "102", Name = "Sweater", Price = 79.99},
                new Product {id = "103", Name = "Winter coat", Price = 149.99},
                new Product {id = "104", Name = "Shoes", Price = 149.99}
            };

        }

        public Product Find()
        {
            return new Product { id = "101", Name = "Polo", Price = 49.99 };
        }



    }




}



