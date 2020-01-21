using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstASP.NET.Data.Models
{
    public class ShopCart
    {
        private readonly AppDBContext _appDBContent;

        public ShopCart(AppDBContext appDBContent)
        {
            this._appDBContent = appDBContent;
        }
        public string ShopCartId { get; set; }

        public List<ShopCartItem> shopCartItems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContext>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);

            return new ShopCart(context) { ShopCartId = shopCartId };
        }

        public void AddToCart(Car car)
        {
            this._appDBContent.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = this.ShopCartId,
                Car = car,
                Price = car.Price
            });

            _appDBContent.SaveChanges();
        }

        public List<ShopCartItem> GetShopItems()
        {
            return _appDBContent.ShopCartItem.Where(c => c.ShopCartId == this.ShopCartId).Include(s => s.Car).ToList();
        }
    }
}
