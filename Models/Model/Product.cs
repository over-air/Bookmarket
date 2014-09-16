using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Model;

namespace Models
{

    public enum Rank:int
    {
        /// <summary>
        /// 九成新
        /// </summary>
        Ninenew=0,
        /// <summary>
        /// 六成新
        /// </summary>
        Sixnew,
        /// <summary>
        /// 三成新
        /// </summary>
        Threenew,
        /// <summary>
        /// 学霸型
        /// </summary>
        Art
    }

    /// <summary>
    /// 商品详情
    /// </summary>
    public class Product
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

        /// <summary>
        /// 等级（新旧程度）
        /// </summary>
        public Rank Rank { get; set; }

        /// <summary>
        /// Navigation Property
        /// </summary>
        public virtual ICollection<Img> Imgs { get; set; }

        public virtual ProDetail ProDetail { get; set; }

    }
}
