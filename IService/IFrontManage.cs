using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Front;

namespace IService
{
    /// <summary>
    /// 前台呈现信息管理
    /// </summary>
    public interface IFrontManage
    {
        /// <summary>
        /// 首页初始化
        /// </summary>
        /// <returns></returns>
        HomePage GetHomePage();

        /// <summary>
        /// 首页默认热卖商品
        /// </summary>
        /// <returns></returns>
        //ProductList GetHotProductList();

        /// <summary>
        /// 批量获取热卖商品(根据类别id)
        /// </summary>
        /// <returns></returns>
        IList<FrontProduct> GetHotProListbycategoryid(int categoryid);

         

    }
}
