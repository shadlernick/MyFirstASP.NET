using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MyFirstASP.NET.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASP.NET.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContext context)
        {                    

            if (!context.Category.Any())
                context.Category.AddRange(Categories.Select(c => c.Value));

            if (!context.Car.Any())
                context.AddRange(
                new Car { Name = "Tesla", ShortDesc = "Топ тачка", LongDesc = "", Available = true, Img = "/img/tesla_picture.jpg", Price = 45000, IsFavourite = true, Category = Categories["Electrocars"] },
                new Car { Name = "Ford", ShortDesc = "Тоже топ тачка", LongDesc = "", Available = true, Img = "/img/ford_picture.jpeg", Price = 45000, IsFavourite = true, Category = Categories["Patrol cars"] });

            context.SaveChanges();
        }

        private static Dictionary<string, Category> _categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (_categories == null)
                {
                    var list = new Category[] {
                        new Category{CategoryName = "Electrocars", Description = "on electric fuel"},
                        new Category{CategoryName = "Patrol cars", Description = "with engine"}
                    };

                    _categories = new Dictionary<string, Category>();
                    foreach (Category c in list)
                    {
                        _categories.Add(c.CategoryName, c);
                    }
                }

                return _categories;
            }
        }
    }
}
