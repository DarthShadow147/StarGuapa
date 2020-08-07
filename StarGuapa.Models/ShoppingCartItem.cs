using System;
using System.Collections.Generic;
using System.Text;

namespace StarGuapa.Models
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public string ShoppingCartId { get; set; }
        public Articulo Articulo { get; set; }
        public int Amount { get; set; }
    }
}
