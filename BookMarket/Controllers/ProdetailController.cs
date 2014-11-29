using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using IBLL;
using Models;
using Models.Model;
using ViewModels;

namespace BookMarket.Controllers
{
    public class ProdetailController : Controller
    {
        BookContext db=new BookContext();
        IOrderManage orderManage=new OrderManage();
        //
        // GET: /Prodetail/
        public ActionResult ProDetail( string proid)
        {
            proid = "1";
            if (string.IsNullOrEmpty(proid)) return View("Error");
            var prodetail = new ProDetails(Convert.ToInt32(proid));
            return View(prodetail);
        }

        /// <summary>
        /// 加入购物车
        /// </summary>
        /// <param name="orderinfo"></param>
        /// <returns></returns>
        public ActionResult AddOrder(Orderinfo orderinfo)
        {
            return Json(orderManage.OrderInsert(orderinfo));
        }

        //直接购买
        //public ActionResult SubmitOrder()



	}
}