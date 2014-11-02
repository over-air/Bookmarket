using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace IBLL
{
    /// <summary>
    /// 商品信息逻辑管理
    /// </summary>
    public interface IProManage
    {
        /// <summary>
        /// 计算一组商品的折算价格
        /// </summary>
        /// <returns></returns>
        //void GetProPrice(IEnumerable<Product> products );

        /// <summary>
        /// 获取折扣价格
        /// </summary>
        /// <param name="rank">商品等级</param>
        /// <param name="cost">原价</param>
        /// <returns></returns>
        decimal GetFinallPrice(int rank, decimal cost);

        /// <summary>
        /// 折扣规则
        /// </summary>
        /// <param name="rank"></param>
        /// <returns></returns>
        double GetDiscount(int rank);

    }
}
