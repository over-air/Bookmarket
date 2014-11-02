using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using ViewModels;

namespace BookMarket.Controllers
{
    public class ProdetailController : Controller
    {
        BookContext db=new BookContext();
        //
        // GET: /Prodetail/
        public ActionResult ProDetail( string proid)
        {
            proid = "1";
            if (string.IsNullOrEmpty(proid)) return View("Error");
            var prodetail = new ProDetails(Convert.ToInt32(proid));
            return View(prodetail);
        }



	}
}