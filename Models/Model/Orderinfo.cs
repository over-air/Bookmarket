using System;

namespace Models.Model
{
    /// <summary>
    /// 单个订单
    /// </summary>
    public class Orderinfo
    {
        public int Id { get; set; }

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
        public virtual Product Product { get; set; }

        public int OrderId { get; set; }

        //斩断外键联系
        //public virtual Order Order { get; set; }
        
    }
}
