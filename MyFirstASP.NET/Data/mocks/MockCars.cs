using MyFirstASP.NET.Data.Interfaces;
using MyFirstASP.NET.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASP.NET.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars 
        { 
            get => 
                new List<Car>
            {
                new Car{Name="Tesla", ShortDesc="Топ тачка", LongDesc="", Available=true, Img="/img/tesla_picture.jpg", Price=45000, IsFavourite=true, Category = _categoryCars.AllCategories.First()},
                new Car{Name="Ford", ShortDesc="Тоже топ тачка", LongDesc="", Available=true, Img="/img/ford_picture.jpeg", Price=45000, IsFavourite=true, Category = _categoryCars.AllCategories.First()}
            };  
        }
        public IEnumerable<Car> FavCars { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
