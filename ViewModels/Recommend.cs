using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    /// <summary>
    /// 推荐商品
    /// </summary>
    public class Recommend
    {
        public int ProductId { get; set; }

        //？？？为什么用userid
        //public int UserId { get; set; }

        /// <summary>
        /// 推荐理由
        /// </summary>
        public string RcmdText { get; set; }

        public Product Product { get; set; }


    }
}
