﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.BackStore;

namespace IService
{
    /// <summary>
    /// 商品信息逻辑管理(后台)
    /// </summary>
    public interface IProManage
    {
        /// <summary>
        /// 计算一组商品的折算价格
        /// </summary>
        /// <returns></returns>
        //void GetProPrice(IEnumerable<Product> products );

        /// <summary>
        /// 获取折扣价格
        /// </summary>
        /// <param name="rank">商品等级</param>
        /// <param name="cost">原价</param>
        /// <returns></returns>
        decimal GetFinallPrice(int rank, decimal cost);

        /// <summary>
        /// 折扣规则
        /// </summary>
        /// <param name="rank"></param>
        /// <returns></returns>
        double GetDiscount(int rank);

        /// <summary>
        /// 添加商品（product、img、prodetail）
        /// </summary>
        /// <param name="productStroe"></param>
        /// <returns></returns>
        int AddProduct(ProductStore productStroe);

        /// <summary>
        /// 获取商品列表
        /// </summary>
        /// <returns></returns>
        List<ProductStore> GetProductList();

        /// <summary>
        /// 根据id获取商品
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ProductStore GetProbyId(int id);

    }
}
