using Microsoft.AspNetCore.Mvc;
using MyFirstASP.NET.Data.Interfaces;
using MyFirstASP.NET.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASP.NET.Controllers
{
    public class HomeController : Controller
    {
        private IAllCars _carRep;

        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                Cars = _carRep.Cars
            };
            return View(homeCars);
        }
    }
}
