using System;

namespace ViewModels
{
    /// <summary>
    /// 单个订单
    /// </summary>
    public class Orderinfo
    {
        public Orderinfo ()
        {
            Dtime = DateTime.Now;
        }

        /// <summary>
        /// 商品个数
        /// </summary>
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
        public int UserId { get; set; }

        public int ProductId { get; set; }
        
    }
}
