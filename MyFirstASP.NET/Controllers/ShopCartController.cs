using Microsoft.AspNetCore.Mvc;
using MyFirstASP.NET.Data.Interfaces;
using MyFirstASP.NET.Data.Models;
using MyFirstASP.NET.Data.Repository;
using MyFirstASP.NET.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASP.NET.Controllers
{
    public class ShopCartController : Controller
    {
        private IAllCars _carRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllCars carRep, ShopCart shopCart)
        {
            _carRep = carRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.GetShopItems();
            _shopCart.shopCartItems = items;

            var obj = new ShopCartViewModel
            {
                ShopCart = _shopCart
            };

            return View(obj);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var item = _carRep.Cars.FirstOrDefault(i => i.Id == id);

            if (item != null)
                _shopCart.AddToCart(item);

            return RedirectToAction("Index");
        }
    }
}
