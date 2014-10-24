using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Models.Model;

namespace ViewModels
{
    /// <summary>
    /// 首页的model
    /// </summary>
    public class HomePage
    {
        public HomePage() { }

        /// <summary>
        /// 选择专业的热卖筛选
        /// </summary>
        /// <param name="instituteId"></param>
        public HomePage(int instituteId)
        {
            Products = null;
        }

        
        /// <summary>
        /// 学院专业列表（左栏菜单）
        /// </summary>
        public IEnumerable<Major> Majors { get; set; }

        /// <summary>
        ///商品列表
        /// </summary>
        public IEnumerable<Product> Products{get;set;}

        /// <summary>
        /// 右栏新品展示
        /// </summary>
        public IEnumerable<Product> NewProducts { get; set; }
 


    }
}
