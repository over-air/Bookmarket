using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Front;

namespace ViewModels.models
{
    /// <summary>
    /// 等级列表
    /// </summary>
    public class ProRank
    {
        /// <summary>
        /// 等级
        /// </summary>
        public Rank Rank { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 对应的价格
        /// </summary>
        public Decimal Price { get; set; }

    }

    public class RankList
    {
        /// <summary>
        /// 总库存
        /// </summary>
        public int Sumcount { get; set; }

        /// <summary>
        /// 各个种类的详情
        /// </summary>
        public IEnumerable<ProRank> ProRanks { get; set; }

    }

}

