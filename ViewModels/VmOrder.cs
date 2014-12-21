using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class VmOrder
    {
         public VmOrder ()
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
        public int Status { get; set; }

        /// <summary>
        /// 不作为外键
        /// </summary>
        public int UserId { get; set; }

        public int ProductId { get; set; }

        //public int OrderId { get; set; }

    }
}
