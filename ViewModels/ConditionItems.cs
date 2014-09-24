using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    /// <summary>
    /// 复杂搜索(排序)条件模型
    /// </summary>
    class ConditionItems
    {
        /// <summary>
        /// 关键字
        /// </summary>
        public string Searchstr { get; set; }

        /// <summary>
        /// 专业id，用‘,’隔开拼接
        /// </summary>
        public string Majors { get; set; } 

        /// <summary>
        /// 学科id拼接
        /// </summary>
        public string SubCates { get ; set; }

        /// <summary>
        /// 新旧程度
        /// </summary>
        public int Rank { get; set; }

        /// <summary>
        /// 是否价格递增
        /// </summary>
        public bool PriceUp { get; set; }

        /// <summary>
        /// 是否销量递减 
        /// </summary>
        public bool SalesDown { get; set; }

    }
}
