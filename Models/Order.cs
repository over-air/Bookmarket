using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 最终订单
    /// </summary>
    public class Order
    {
        public int ID { get; set; }

        public ICollection<Orderinfo> Orderinfos { get; set; } 

        /// <summary>
        /// 最终订单生成时间
        /// </summary>
        public DateTime Dtime { get; set; }

        public int AddressID { get; set; }
        public virtual Address Address { get; set; }

    }
}
