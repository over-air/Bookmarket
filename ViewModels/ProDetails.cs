using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.Model;

namespace ViewModels
{
    /// <summary>
    /// 商品详情
    /// </summary>
    class ProDetails
    {
        /// <summary>
        /// 商品具体介绍信息
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// 新旧等级
        /// </summary>
        public Rank Rank { get; set; } 

        /// <summary>
        /// 销售数量
        /// </summary>
        public int Salesnum { get; set; }

        /// <summary>
        /// 左下栏商品推荐
        /// </summary>
        public IEnumerable<Product> ProductsRmd { get; set; }

        /// <summary>
        /// 商品评价
        /// </summary>
        public IEnumerable<Review> Reviews { get; set; } 

    }
}
