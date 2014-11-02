using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    /// <summary>
    /// 仓库
    /// </summary>
    public class Store
    {
        public int Id { get; set; }

        public int ProductId { set; get; }

        /// <summary>
        /// 商品新旧类型
        /// </summary>
        public Rank Rank { get; set; }

        /// <summary>
        /// 折算价格(可空，只在查出来后后台处理)
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 商品一类型库存数量
        /// </summary>
        public int Count { get; set; }

        public virtual Product Product { get; set; }

    }
}
