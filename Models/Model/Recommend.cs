﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    /// <summary>
    /// 推荐商品
    /// </summary>
    public class Recommend
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        //为什么用userid
        //public int UserId { get; set; }

        /// <summary>
        /// 推荐理由
        /// </summary>
        public string RcmdText { get; set; }

        public virtual Product Product { get; set; }

        //public virtual User User { get; set; }

    }
}