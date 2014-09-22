using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Model;

namespace IBLL
{
    /// <summary>
    /// 订单逻辑处理
    /// </summary>
    interface IOrderManage
    {
        /// <summary>
        /// 插入订单详情（加入购物车）
        /// </summary>
        /// <param name="orderinfo"></param>
        void OrderInsert(Orderinfo orderinfo);


        /// <summary>
        /// 提交订单(新建订单order，更新orderinfo)
        /// </summary>
        void SubmitOrder(int addressId,IEnumerable<Orderinfo> orderinfos);

    }
}
