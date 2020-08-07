using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StarGuapa.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarGuapa.Models
{
    public class ShoppingCart
    {
        private readonly ApplicationDbContext _db;
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public ShoppingCart(ApplicationDbContext db)
        {
            _db = db;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<ApplicationDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Articulo articulo, int amount)
        {
            var shoppingCartItem = _db.ShoppingCartItem.SingleOrDefault(s => s.Articulo.Id == articulo.Id && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Articulo = articulo,
                    Amount = amount
                };

                _db.ShoppingCartItem.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }

            _db.SaveChanges();
        }

        public int RemoveFromCart(Articulo articulo)
        {
            var shoppingCartItem = _db.ShoppingCartItem.SingleOrDefault(s => s.Articulo.Id == articulo.Id && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _db.ShoppingCartItem.Remove(shoppingCartItem);
                }
            }

            _db.SaveChanges();
            return localAmount;
        }

        public int IncrementToCart(Articulo articulo)
        {
            var shoppingCartItem = _db.ShoppingCartItem.SingleOrDefault(s => s.Articulo.Id == articulo.Id && s.ShoppingCartId == ShoppingCartId);
            var localAmount = 1;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount >= 1)
                {
                    shoppingCartItem.Amount++;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _db.ShoppingCartItem.Remove(shoppingCartItem);
                }
            }

            _db.SaveChanges();
            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _db.ShoppingCartItem.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Include(s => s.Articulo)
                .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _db.ShoppingCartItem.Where(c => c.ShoppingCartId == ShoppingCartId);

            _db.ShoppingCartItem.RemoveRange(cartItems);
            _db.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _db.ShoppingCartItem.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Articulo.Precio * c.Amount).Sum();

            return total;
        }
    }
}
