using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using IBLL;
using Models;

namespace BLL
{
     public class ProManage:IProManage
    {
         /// <summary>
         /// 确定一组商品价格
         /// </summary>
         /// <param name="products"></param>
         /// <returns></returns>
         //public void GetProPrice(IEnumerable<Product> products )
         //{
         //    var pros = products as IList<Product> ?? products.ToList();//为什么要这么做
         //    foreach (var product in pros)
         //    {
         //        product.Price = GetFinallPrice(product);
         //    }
         //}


         /// <summary>
         /// 由商品信息得出最终价格（暂时：9:100%;7:90%;art:90%;5:75%;old:30%:）
         /// </summary>
         /// <param name="rank"></param>
         /// <param name="cost"></param>
         /// <returns></returns>
         public decimal GetFinallPrice(int rank,decimal cost)
         {
             double disocunt = GetDiscount(Convert.ToInt32(rank));
             return (decimal)((double)cost*disocunt);
         }

         /// <summary>
         /// 折扣规则
         /// </summary>
         /// <param name="rank"></param>
         /// <returns></returns>
         public double GetDiscount(int rank)
         {
             if (rank == (int) Models.Rank.Ninenew || rank == (int) Models.Rank.Art) return 1;
             else if (rank == (int) Models.Rank.Sevennew) return 0.9;
             else if (rank == (int) Models.Rank.Fivenew) return 0.8;
             else if (rank == (int) Models.Rank.Old) return 0.7;
             else
             {
                 Common.ReportEx(HttpContext.Current.Request.Url.AbsolutePath, "根据新旧获取折扣，出现意外等级", HttpContext.Current.Session["userid"].ToString());
                 return 1;
             }
         }

    }
}
