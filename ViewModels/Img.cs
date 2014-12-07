using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class Img
    {
        /// <summary>
        /// 图片相对路径
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 图片附加说明
        /// </summary>
        public string Illustration { get; set; }

        /// <summary>
        /// 外键
        /// </summary>
        public int ProductId { get; set; }
    }
}
