using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace ViewModels
{
    /// <summary>
    /// 商品集
    /// </summary>
    class ProList
    {
        private IEnumerable<Product> products; 

        public ProList(){}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="instituteId"></param>
        public ProList(int instituteId)
        {
            
        }

        /// <summary>
        /// 结果集
        /// </summary>
        public IEnumerable<Product> Products { get; set; } 
    }
}
