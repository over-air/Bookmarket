using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 单个订单
    /// </summary>
    public class Orderinfo
    {
        public int ID { get; set; }

        public int Count { get; set; }

        /// <summary>
        /// 生成时间
        /// </summary>
        public DateTime Dtime { get; set; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// 不作为外键
        /// </summary>
        public int UserID { get; set; }

        public int ProductID { get; set; }
        public virtual Product Product { get; set; }

        public int OrderID { get; set; }
        public virtual Order Order { get; set; }

    }
}
