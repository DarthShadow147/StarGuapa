using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarGuapa.DataAccess.Data;
using StarGuapa.Models;
using StarGuapa.Models.Data;
using StarGuapa.Models.Data.Repository;
using StarGuapa.Models.ViewModels;

namespace StarGuapa.Areas.Client.Controllers
{
    [Area("Client")]
    public class OrdenController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IOrdenRepository _ordenRepository;
        private readonly ShoppingCart _shoppingCart;

        public OrdenController(ApplicationDbContext db, IOrdenRepository ordenRepository, ShoppingCart shoppingCart)
        {
            _db = db;
            _ordenRepository = ordenRepository;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Orden orden)
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "El carro esta vacio");
            }

            if (ModelState.IsValid)
            {
                _ordenRepository.CrearOrden(orden);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(orden);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Gracias por tu orden. Disfruta tus productos";
            return View();
        }
    }
}
