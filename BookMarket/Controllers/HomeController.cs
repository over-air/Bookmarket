using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IService;
using Service;
using ViewModels.Front;

namespace BookMarket.Controllers
{
    public class HomeController : Controller
    {
        readonly IFrontManage _frontManage=new FrontManage();

        public ActionResult Index()
        {
            var model = _frontManage.GetHomePage();
            return View(model);
        }

        public JsonResult GetHotListbyCategoryid(int id)
        {
            var prolist= _frontManage.GetHotProListbycategoryid(id);
            return Json(prolist);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}