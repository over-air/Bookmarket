using System;
using System.Collections.Generic;
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
        public ActionResult PartialImgs(int? productId)
        {
            //if (string.IsNullOrEmpty(productId)) return View("Error");
            var image = new Images(Convert.ToInt32(productId));
            //if (!image.Imgs.Any())
            //{
            //    image.Imgs = new List<Img>() {new Img(){Url ="zanwu.jpg",Illustration = "暂无图片"}};
            //}
            return PartialView(image);
        }

	}
}