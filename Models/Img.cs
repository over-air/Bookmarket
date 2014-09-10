using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// 图片
    /// </summary>
    public class Img
    {
        public int ID { get; set; }
        /// <summary>
        /// 图片相对路径
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 外键
        /// </summary>
        public int ProductID { get; set; }

        /// <summary>
        /// Navigation Properties
        /// </summary>
        public virtual Product Product { get; set; }

    }
}
