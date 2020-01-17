using MyFirstASP.NET.Data.Interfaces;
using MyFirstASP.NET.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASP.NET.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryName = "Electrocars", Description = "on electric fuel"},
                    new Category{CategoryName = "Patrol cars", Description = "with engine"},
                };
            }
        }
    }
}
