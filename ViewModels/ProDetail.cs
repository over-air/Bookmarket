﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ViewModels.Front;

namespace ViewModels
{
    /// <summary>
    /// 商品详情内容描述（待续）
    /// </summary>
    public class ProDetail
    {
        [Key]
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public string Details { get; set; }

        public FrontProduct Product { get; set; }

    }
}
