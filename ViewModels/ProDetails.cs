using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.models;

namespace ViewModels
{
    /// <summary>
    /// 商品详情
    /// </summary>
    public class ProDetails
    {
        //BookContext db=new BookContext();
        /// <summary>
        /// 获取一个商品详情
        /// </summary>
        /// <param name="proid"></param>
        public ProDetails(int proid)
        {
            //Product = db.Products.Find(proid);
            //var proranks = new List<ProRank>();
            //int count = 0;
            //foreach (var store in db.Stores.Where(m=>m.ProductId==proid))
            //{
            //    var rank = new ProRank() {Count = store.Count, Price = store.Price,Rank = store.Rank};
            //    proranks.Add(rank);
            //    count += store.Count;
            //}
            //RankList = new RankList() {ProRanks = proranks, Sumcount = count};
        }

        /// <summary>
        /// 商品具体介绍信息
        /// </summary>
        public Product Product { get; set; }

        /// <summary>
        /// 销售数量
        /// </summary>
        public int Salesnum { get; set; }

        /// <summary>
        /// 左下栏商品推荐（改为partialview加载方式）
        /// </summary>
        //public IEnumerable<Product> ProductsRmd { get; set; }

        /// <summary>
        /// 商品评价
        /// </summary>
        public IEnumerable<Review> Reviews { get; set; }

        /// <summary>
        /// 商品种类库存情况
        /// </summary>
        public RankList RankList { get; set; }

    }
}