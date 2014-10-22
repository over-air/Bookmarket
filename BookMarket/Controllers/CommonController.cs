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
        public ActionResult PartialImgs(int productId)
        {
            var image = new Images(productId);
            return PartialView(image);
        }

	}
}