using Microsoft.EntityFrameworkCore;
using MyFirstASP.NET.Data.Interfaces;
using MyFirstASP.NET.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASP.NET.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContext _appDBContent;

        public CarRepository(AppDBContext appDBContent)
        {
            this._appDBContent = appDBContent;
        }
        public IEnumerable<Car> Cars => _appDBContent.Car.Include(c => c.Category);

        public IEnumerable<Car> FavCars => _appDBContent.Car.Where(p => p.IsFavourite).Include(c => c.Category);

        public Car getObjectCar(int carId)
        {
            return _appDBContent.Car.FirstOrDefault(p => p.Id == carId);
        }
    }
}
