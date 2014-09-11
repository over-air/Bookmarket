using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Address
    {
        public int ID { get; set; }

        /// <summary>
        /// 订单详细地址（校内详细地址，不与人名挂钩）
        /// </summary>
        public string Addr { get; set; }



        /// <summary>
        /// 外键
        /// </summary>
        public int UserID { get; set; }
        public virtual User User { get; set; }

        public virtual FinalOrder Order { get; set; }

    }
}
