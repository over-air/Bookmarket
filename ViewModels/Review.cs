using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    /// <summary>
    /// 评论列表
    /// </summary>
    public class Review
    {
        public int Id { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// 评论详情
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 总体新旧程度
        /// </summary>
        public int Old { get; set; }

        /// <summary>
        /// 订单满意度
        /// </summary>
        public int Satisfaction { get; set; }

        public int OrderId { get; set; }
        //public virtual Order Order { get; set; }

    }
}
