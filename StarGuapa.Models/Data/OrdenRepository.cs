using StarGuapa.DataAccess.Data;
using StarGuapa.Models.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarGuapa.Models.Data
{
    public class OrdenRepository : IOrdenRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly ShoppingCart _shoppingCart;

        public OrdenRepository(ApplicationDbContext db, ShoppingCart shoppingCart)
        {
            _db = db;
            _shoppingCart = shoppingCart;
        }

        public void CrearOrden(Orden orden)
        {
            orden.OrdenFecha = DateTime.Now;
            orden.Estado = 1;
            orden.OrdenTotal = _shoppingCart.GetShoppingCartTotal();
            _db.Orden.Add(orden);
            _db.SaveChanges();

            var shoppingCartItems = _shoppingCart.GetShoppingCartItems();

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrdenDetalle
                {
                    Cantidad = shoppingCartItem.Amount,
                    Precio = shoppingCartItem.Articulo.Precio,
                    articuloId = shoppingCartItem.Articulo.Id,
                    OrdenId = orden.Id
                };

                _db.OrdenDetalle.Add(orderDetail);
            }

            _db.SaveChanges();
        }
    }
}
