using Microsoft.AspNetCore.Mvc;
using MyFirstASP.NET.Data.Interfaces;
using MyFirstASP.NET.Data.Models;
using MyFirstASP.NET.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASP.NET.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCategory)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCategory;
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = _allCars.Cars.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                    cars = _allCars.Cars.Where(i => i.Category.CategoryName.Equals("electro")).OrderBy(i => i.Id);
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                    cars = _allCars.Cars.Where(i => i.Category.CategoryName.Equals("fuel")).OrderBy(i => i.Id);
            }

            currCategory = _category;

            var carObj = new CarsListViewModel { GetAllCars = cars, CurrCategory = currCategory };

            ViewBag.Title = "Страница с автомобилями";

            return View(carObj);
        }

        [Route("Cars/About/{name}")]
        public ViewResult About(string name)
        {

            var carObj = new CarViewModel
            {
                Car = _allCars.Cars.Where(i => i.Name == name).FirstOrDefault()
            };

            return View(carObj);
        }

        [Route("Cars/Favourite")]
        public ViewResult Favourite()
        {
            IEnumerable<Car> cars = null;

            cars = _allCars.FavCars;

            var carObj = new CarsListViewModel { GetAllCars = cars };

            ViewBag.Title = "Страница с автомобилями";

            return View(carObj);
        }
    }
}
