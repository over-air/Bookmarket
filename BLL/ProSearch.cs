using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Models;
using Models.Model;

namespace BLL
{
    public class ProSearch:IProSearch
    {
        BookContext db=new BookContext();

        /// <summary>
        /// 模糊搜索
        /// </summary>
        /// <param name="searchstr">参数</param>
        /// <returns></returns>
        public IEnumerable<Product> GetProbySearch(string searchstr)
        {
            return null;
        }

        /// <summary>
        /// 根据专业信息查找
        /// </summary>
        /// <param name="ht">majorid:专业,grade:年纪（0不考虑）,term:学期（0不考虑）</param>
        /// <returns></returns>
        public IEnumerable<Product> GetProbyTerm(Hashtable ht)
        {
            int majorId=Convert.ToInt32(ht["majorid"]??"0");
            int grade = Convert.ToInt32(ht["grade"] ?? "0");
            int term = Convert.ToInt32(ht["term"] ?? "0");

            var classpro = from pro in db.Products
                join c in db.Classifies on pro.Id equals c.ProductId
                where c.MajorId == majorId && (grade == 0 || (int) c.Grade == grade) &&
                    (term == 0 || (int) c.Term == term)
                select pro;
            return classpro;
        }

        /// <summary>
        /// 推荐商品（右栏显示）
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Product> GetProRecom()
        {
            var prolist = from r in db.Recommends
                          orderby r.ProductId descending 
                select r.Product;
            return prolist.Take(5);
        }
    }
}
