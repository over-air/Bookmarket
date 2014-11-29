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
        /// 七成新
        /// </summary>
        Sevennew,
        /// <summary>
        /// 五成新
        /// </summary>
        Fivenew,
        /// <summary>
        /// 旧书
        /// </summary>
        Old,
        /// <summary>
        /// 学霸型
        /// </summary>
        Art
    }

    /// <summary>
    /// 商品类型
    /// </summary>
    public enum Typeof : int
    {
        /// <summary>
        /// 书
        /// </summary>
        Book=1
    }

    /// <summary>
    /// 商品详情
    /// </summary>
    public class Product
    {
        public int Id { get; set; }

        /// <summary>
        /// 商品类型
        /// </summary>
        public Typeof Typeof { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 书本原始定价
        /// </summary>
        public decimal Valuation { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// 顶端描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 等级（新旧程度）
        /// </summary>
       /// public Rank Rank { get; set; }

        /// <summary>
        /// （搜索结果）展示图片url
        /// </summary>
        public string Showurl { get; set; }

        /// <summary>
        /// Navigation Property
        /// </summary>
        public virtual ICollection<Img> Imgs { get; set; }

        public virtual ProDetail ProDetail { get; set; }

        public virtual ICollection<Recommend> Recommends { get; set; } 

    }
}
