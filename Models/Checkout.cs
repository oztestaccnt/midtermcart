using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTMLHelpers.Models
{
    public class Checkout
    {
        public string Name { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
    }

    public class ShoppingCartItem
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

    }


}