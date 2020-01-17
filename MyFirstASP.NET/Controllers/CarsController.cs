using Microsoft.AspNetCore.Mvc;
using MyFirstASP.NET.Data.Interfaces;
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

        public ViewResult List()
        {
            ViewBag.Title = "Страница с автомобилями";
            var carsListVM = new CarsListViewModel();
            carsListVM.GetAllCars = _allCars.Cars;
            carsListVM.CurrCategory = "Электромобили";
            return View(carsListVM);
        }
    }
}
