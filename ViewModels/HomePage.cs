using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using IBLL;
using ViewModels;

namespace ViewModels
{
    /// <summary>
    /// 首页的model
    /// </summary>
    public class HomePage
    {
        //BookContext db=new BookContext();

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
        public IEnumerable<Product> Products{get;set;}

        /// <summary>
        /// 右栏新品展示
        /// </summary>
        public IEnumerable<Product> NewProducts { get; set; }
 


    }
}
