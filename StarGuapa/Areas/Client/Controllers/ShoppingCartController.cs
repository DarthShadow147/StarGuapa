using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarGuapa.DataAccess.Data.Repository;
using StarGuapa.Models;
using StarGuapa.Models.ViewModels;

namespace StarGuapa.Areas.Client.Controllers
{
    [Area("Client")]
    public class ShoppingCartController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly IArticuloRepository _articuloRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IContenedorTrabajo contenedorTrabajo, IArticuloRepository articuloRepository, ShoppingCart shoppingCart)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _articuloRepository = articuloRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int articuloId)
        {
            var selectedArticulo = _articuloRepository.GetAllArticulos.FirstOrDefault(a => a.Id == articuloId);

            if (selectedArticulo != null)
            {
                _shoppingCart.AddToCart(selectedArticulo, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int articuloId)
        {
            var selectedArticulo = _articuloRepository.GetAllArticulos.FirstOrDefault(a => a.Id == articuloId);

            if (selectedArticulo != null)
            {
                _shoppingCart.RemoveFromCart(selectedArticulo);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult IncrementToShoppingCart(int articuloId)
        {
            var selectedArticulo = _articuloRepository.GetAllArticulos.FirstOrDefault(a => a.Id == articuloId);

            if (selectedArticulo != null)
            {
                _shoppingCart.IncrementToCart(selectedArticulo);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult ClearCart()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }

    }
}
