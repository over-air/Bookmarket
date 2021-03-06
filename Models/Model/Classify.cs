﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Model
{
    public enum Grade:int
    {
        /// <summary>
        /// 大一
        /// </summary>
        One=0,
        /// <summary>
        /// 大二
        /// </summary>
        Two,
        /// <summary>
        /// 大三
        /// </summary>
        Three,
        /// <summary>
        /// 大四
        /// </summary>
        Four,
        /// <summary>
        /// 研一
        /// </summary>
        PgOne=0,
        /// <summary>
        /// 研二
        /// </summary>
        PgTwo,
        /// <summary>
        /// 研三
        /// </summary>
        PgThree
    }

    public enum Term:int
    {
        One=0,
        Two
    }

    /// <summary>
    /// 产品（书本）的分类  测试
    /// </summary>
    public class Classify
    {
        /// <summary>
        /// 产品ID
        /// </summary>
        [Key]
        public int ProductId { get; set; }

        /// <summary>
        /// 专业ID
        /// </summary>
        public int MajorId { get; set; }

        /// <summary>
        /// 学科Id
        /// </summary>
        public int SubCategoryId { get; set; }

        /// <summary>
        /// 年级
        /// </summary>
        public Grade Grade{ get; set; }
        /// <summary>
        /// 学期
        /// </summary>
        public Term Term { get; set; }


        //斩断联系，用left join
        //public virtual Product Product { get; set; }

        public virtual Major Major { get; set; }

        public virtual SubCategory SubCategory { get; set; }

    }
}
