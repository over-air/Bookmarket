using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IService;
using ViewModels.Front;

namespace Service
{
    public class FrontManage:IFrontManage
    {
        /// <summary>
        /// 首页初始化
        /// </summary>
        /// <returns></returns>
        public HomePage GetHomePage()
        {
            //实现
            return new HomePage();
        }

        /// <summary>
        /// 首页默认热卖商品
        /// </summary>
        /// <returns></returns>
        //ProductList GetHotProductList();

        /// <summary>
        /// 批量获取热卖商品(根据类别id)
        /// </summary>
        /// <returns></returns>
        public IList<FrontProduct> GetHotProListbycategoryid(int categoryid)
        {
            //实现
            return new List<FrontProduct>();
        }
    }
}
