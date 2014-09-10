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
    public class Product
    {
        public int ID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 顶端描述
        /// </summary>
        public string Description { get; set; }



        /// <summary>
        /// Navigation Property
        /// </summary>
        public virtual ICollection<Img> Imgs { get; set; } 

    }
}
