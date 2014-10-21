using System;
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
        /// <param name="majorId">专业</param>
        /// <param name="grade">年级，可以为0，即不考虑</param>
        /// <param name="term">学期，可以为0，即不考虑</param>
        /// <returns></returns>
        public IEnumerable<Product> GetProbyTerm(int majorId, int grade, int term)
        {
            var classpro = from c in db.Classifies
                where c.MajorId == majorId && (grade == 0 || (int) c.Grade == grade) &&(term==0||(int)c.Term==term)
                select c.Product;//求测试
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
