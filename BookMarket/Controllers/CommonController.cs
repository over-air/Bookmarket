using System.Linq;
using System.Web.Mvc;
using Models;
using ViewModels;

namespace BookMarket.Controllers
{
    public class CommonController : Controller
    {
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
        public ActionResult PartialImgs()
        {
            var db = new BookContext();
            var imgs = db.Imgs.ToList();
            var model = new Images {Imgs = imgs};
            return PartialView(model);
        }

	}
}