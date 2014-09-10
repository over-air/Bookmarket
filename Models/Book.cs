using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 商品详情
    /// </summary>
    public class Book
    {
        public int Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 顶端描述
        /// </summary>
        public string Description { get; set; }

        public string ImgUrl { get; set; }

    }
}
