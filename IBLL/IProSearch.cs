using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace IBLL
{
    interface IProSearch
    {
        /// <summary>
        /// 模糊搜索
        /// </summary>
        /// <param name="searchstr">参数</param>
        /// <returns></returns>
        IEnumerable<Product> GetProbySearch(string searchstr);

        /// <summary>
        /// 根据详细信息查找
        /// </summary>
        /// <param name="instituteId">专业</param>
        /// <param name="grade">年级，可以为0，即不考虑</param>
        /// <param name="term">学期，可以为0，即不考虑</param>
        /// <returns></returns>
        IEnumerable<Product> GetProbyTerm(int instituteId, int grade, int term);

    }
}
