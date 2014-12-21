﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using IBLL;
using Models;
using ViewModels;

namespace BookMarket.Controllers
{
    public class ProdetailController : Controller
    {
        BookContext db = new BookContext();
        IOrderManage orderManage = new OrderManage();
        //
        // GET: /Prodetail/
        public ActionResult ProDetail(int? proid)
        {
            try
            {
                var prodetail = new ProDetails(Convert.ToInt32(proid));
                return View(prodetail);
            }
            catch (Exception ex)
            {
                BLL.Common.ReportEx(System.Web.HttpContext.Current.Request.Url.AbsolutePath, "宝贝不存在" + ex.Message, System.Web.HttpContext.Current.Session["userid"].ToString());
                return View("Error");//宝贝已不存在
            }
        }

        /// <summary>
        /// 加入购物车
        /// </summary>
        /// <param name="orderinfo"></param>
        /// <returns></returns>
        //public ActionResult AddOrder(Orderinfo orderinfo)
        //{
        //    return Json(orderManage.OrderInsert(orderinfo));
        //}

        //直接购买
        //public ActionResult DirectBuy(Orderinfo orderinfo)
        //{
        //    if (orderManage.OrderInsert(orderinfo) > 0)
        //    {
        //        return View("Error"); //指向订单页面
        //    }
        //    return View("ProDetail");
        //}



    }
}