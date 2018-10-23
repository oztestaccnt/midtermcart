using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTMLHelpers.Models
{
    
    public class Order
    {
        //undo

        [Required]
        [Range(1, 50)]
        public int Qty { get; set; }
        public Product Prod { get; set; }
        public Product Price { get; set; }
        public Product CustName { get; set; }
        public Product CustAddress { get; set; }


        //public string ProductKey { get; set; }
        //public int Qty { get; set; }

    }
}