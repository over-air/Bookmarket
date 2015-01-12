using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using Models;
using Models.Model;

namespace BookMarket.Controllers
{
    public class InitController : Controller
    {
        BookContext db = new BookContext();
        //
        // GET: /Test/
        public ActionResult Index()
        {
            InitDataBase();
            var test = db.Products.ToList();
            var test2 = db.Orders.ToList();
            return View();
        }

        public void InitDataBase()
        {
            List<Product> products=new List<Product>()
            {
                new Product(){Typeid = 1,Name = "测试商品1",Cost = 12,Description = "这是一条测试商品的描述1",Showurl = "small.jpg"},
                new Product(){Typeid = 1,Name = "测试商品2",Cost = 14,Description = "这是一条测试商品的描述2",Showurl = "small.jpg"},
                new Product(){Typeid = 1,Name = "测试商品3",Cost = 16,Description = "这是一条测试商品的描述3",Showurl = "small.jpg"},
                new Product(){Typeid = 1,Name = "测试商品4",Cost = 18,Description = "这是一条测试商品的描述4",Showurl = "small.jpg"},
                new Product(){Typeid = 1,Name = "测试商品5",Cost = 20,Description = "这是一条测试商品的描述5",Showurl = "small.jpg"},
                new Product(){Typeid = 1,Name = "测试商品6",Cost = 21,Description = "这是一条测试商品的描述6",Showurl = "small.jpg"},
                new Product(){Typeid = 1,Name = "测试商品7",Cost = 22,Description = "这是一条测试商品的描述7",Showurl = "small.jpg"},
                new Product(){Typeid = 1,Name = "测试商品8",Cost = 23,Description = "这是一条测试商品的描述8",Showurl = "small.jpg"},
            };
            foreach (var product in products)
            {
                db.Products.Add(product);
            }
            db.SaveChanges();

            List<Img> imgs=new List<Img>()
            {
                new Img(){ProductId = 1,Illustration = "这是图片详情描述1",Url="sample1.jpg"},
                new Img(){ProductId = 1,Illustration = "这是图片详情描述2",Url="sample2.jpg"},
                new Img(){ProductId = 1,Illustration = "这是图片详情描述3",Url="sample3.jpg"},
                new Img(){ProductId = 1,Illustration = "这是图片详情描述4",Url="sample4.jpg"},
                new Img(){ProductId = 1,Illustration = "这是图片详情描述5",Url="sample1.jpg"},
            };
            foreach (var img in imgs)
            {
                db.Imgs.Add(img);
            }
            var users = new List<User>()
            {
                new User() {Name = "max"},
                new User() {Name = "Test"}
            };
            foreach (var user in users)
            {
                db.Users.Add(user);
            }

            var stores = new List<Store>()
            {
                new Store() {ProductId = 1, Rank = Rank.Art, Price = 10, Count = 10},
                new Store() {ProductId = 1, Rank = Rank.Art, Price = 9, Count = 20},
                new Store() {ProductId = 1, Rank = Rank.Art, Price = 8, Count = 20},
                new Store() {ProductId = 1, Rank = Rank.Art, Price = 7, Count = 10},
                new Store() {ProductId = 1, Rank = Rank.Art, Price = 6, Count = 10}

            };
            foreach (var store in stores)
            {
                db.Stores.Add(store);
            }

            db.SaveChanges();


        }


	}
}