using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace IBLL
{
    public interface IProSearch
    {
        /// <summary>
        /// 模糊搜索
        /// </summary>
        /// <param name="searchstr">参数</param>
        /// <returns></returns>
        IEnumerable<Product> GetProbySearch(string searchstr);

        /// <summary>
        /// 根据专业信息查找
        /// </summary>
        /// <param name="ht">majorid:专业,grade:年纪（0不考虑）,term:学期（0不考虑）</param>
        /// <returns></returns>
        IEnumerable<Product> GetProbyTerm(Hashtable ht);

        /// <summary>
        /// 推荐商品（右栏显示）
        /// </summary>
        /// <returns></returns>
        IEnumerable<Product> GetProRecom();

    }
}
