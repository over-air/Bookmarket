using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Model
{
    /// <summary>
    /// 商品类目
    /// </summary>
    public class Category
    {
        /// <summary>
        /// 自己id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 父级id
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// 描述内容
        /// </summary>
        public string Content { get; set; }
    }
}
