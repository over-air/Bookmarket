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
        /// 商品评价
        /// </summary>
        public IEnumerable<Review> Reviews { get; set; } 

    }
}
