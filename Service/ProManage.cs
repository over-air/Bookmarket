using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IService;
using ViewModels.BackStore;

namespace Service
{
    public class ProManage:IProManage
    {
        /// <summary>
        /// 获取折扣价格
        /// </summary>
        /// <param name="rank">商品等级</param>
        /// <param name="cost">原价</param>
        /// <returns></returns>
        public decimal GetFinallPrice(int rank, decimal cost)
        {
            return 9;
        }

        /// <summary>
        /// 折扣规则
        /// </summary>
        /// <param name="rank"></param>
        /// <returns></returns>
        public double GetDiscount(int rank)
        {
            return 9.8;
        }

        /// <summary>
        /// 添加商品（product、img、prodetail）
        /// </summary>
        /// <param name="productStore"></param>
        /// <returns></returns>
        public int AddProduct(ProductStore productStore)
        {
            //成功：1；否则：失败
            return 1;
        }
        /// <summary>
        /// 获取商品列表
        /// </summary>
        /// <returns></returns>
        public List<ProductStore> GetProductList()
        {
            //实现
            return new List<ProductStore>();
        }

        /// <summary>
        /// 根据id获取商品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProductStore GetProbyId(int id)
        {
            //实现
            return new ProductStore();
        }

    }
}
