using System;
using System.Drawing;
using System.Linq;
using System.Web.Mvc;
using Models;
using ViewModels;

namespace BookMarket.Controllers
{
    public class CommonController : Controller
    {
        BookContext db=new BookContext();
        //
        // GET: /Common/
        //public ActionResult Index()
        //{
        //    return View();
        //}

        /// <summary>
        /// 图片轮询分部视图
        /// </summary>
        /// <returns></returns>
        public ActionResult PartialImgs(string productId)
        {
            productId = "1";
            if (string.IsNullOrEmpty(productId)) return View("Error");
            var image = new Images(Convert.ToInt32(productId));
            return PartialView(image);
        }

	}
}