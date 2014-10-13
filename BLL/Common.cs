using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// 公共逻辑类
    /// </summary>
    public static class Common
    {
        /// <summary>
        /// 出错提醒
        /// </summary>
        /// <param name="url">出错页url</param>
        /// <param name="exmsg">出错信息（中文描述+ex.message）</param>
        /// <param name="userid">用户id</param>
        public static void ReportEx(string url,string exmsg,string userid)
        {
            //用webservice的方式处理报错信息
        }
    }
}
