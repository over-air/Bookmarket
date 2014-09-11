﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum SendTime
    {
        /// <summary>
        /// 上午（9:00～11:00）
        /// </summary>
        Am=0,
        /// <summary>
        /// 中午(11:00～2:00)
        /// </summary>
        Noon,
        /// <summary>
        /// 下午(2:00～6:00)
        /// </summary>
        Pm,
        /// <summary>
        /// 晚上(6:00～9:00)
        /// </summary>
        Night
    }

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

        /// <summary>
        /// 订单派送时间
        /// </summary>
        public SendTime SendTime { get; set; }

        public int AddressID { get; set; }
        public virtual Address Address { get; set; }

    }
}
