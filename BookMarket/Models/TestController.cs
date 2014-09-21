using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;

namespace BookMarket.Models
{
    public class TestController : Controller
    {
        BookContext db=new BookContext();
        //
        // GET: /Test/
        public ActionResult Index()
        {
            var test = db.Products.ToList();
            return View();
        }
	}
}