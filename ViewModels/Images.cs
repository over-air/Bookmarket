using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    /// <summary>
    /// 轮询图片集
    /// </summary>
    public class Images
    {
        //BookContext db=new BookContext();

        public IEnumerable<Img> Imgs { get; set; }

        /// <summary>
        /// 获取产品对应图片
        /// </summary>
        /// <param name="proid">产品id</param>
        public Images(int proid)
        {
            //Imgs = db.Imgs.Where(m => m.ProductId == proid);
        }

    }
}
