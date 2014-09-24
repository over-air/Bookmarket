using System;
using System.Collections.Generic;
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
        public int ProductId { get; set; }

        /// <summary>
        /// 推荐理由
        /// </summary>
        public string RcmdText { get; set; }

        public virtual Product Product { get; set; }

    }
}
