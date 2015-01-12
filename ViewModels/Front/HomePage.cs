using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace ViewModels.Front
{
    /// <summary>
    /// 首页的model
    /// </summary>
    public class HomePage
    {
        /// <summary>
        /// 默认热卖筛选
        /// </summary>
        public HomePage()
        {
            ////Majors = db.Majors.ToList();
            ////Products = db.Products.ToList();//筛选方式待定
            ////NewProducts = db.Products.Take(5);
            //IProManage promanage=new ProManage();//接口的用法？？？
            //promanage.GetProPrice(Products);
            //promanage.GetProPrice(NewProducts);
        }

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
        public IEnumerable<FrontProduct> Products{get;set;}

        /// <summary>
        /// 右栏新品展示
        /// </summary>
        public IEnumerable<FrontProduct> NewProducts { get; set; }
 


    }
}
