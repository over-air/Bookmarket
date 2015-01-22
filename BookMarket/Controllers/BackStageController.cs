using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IService;
using Service;
using ViewModels.BackStore;

namespace BookMarket.Controllers
{
    public class BackStageController : Controller
    {
        readonly IProManage _proManage = new ProManage();
        //
        // GET: /BackStage/
        public ActionResult ProManage( int? id)
        {
            var productstore = new ProductStore();
            //if (id.HasValue) productstore = _proManage.GetProbyId((int) id);
            return View("ProManage",productstore);
        }

        [HttpPost]
        public ActionResult SaveProduct(ProductStore productStore)
        {
            var result= _proManage.AddProduct(productStore);
            if (result == 1) return View("ProManage");
            return View("ProManage", productStore);
        }

        public ActionResult ProductList()
        {
            var productlist=_proManage.GetProductList();
            return View("ProductList",productlist);
        }

	}
}