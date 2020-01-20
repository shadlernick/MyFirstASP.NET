using MyFirstASP.NET.Data.Interfaces;
using MyFirstASP.NET.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASP.NET.Data.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBContext _appDBContent;
        public CategoryRepository(AppDBContext appDBContent)
        {
            this._appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllCategories => _appDBContent.Category;
    }
}
