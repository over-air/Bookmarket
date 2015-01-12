using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace ViewModels.Front
{
    public class FrontProduct
    {
        public Product Product { get; set; }

        /// <summary>
        /// 最低价
        /// </summary>
        public decimal FloorPrice { get; set; }
    }
}
