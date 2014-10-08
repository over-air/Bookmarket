using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Model;

namespace ViewModels
{
    /// <summary>
    /// 轮询图片集
    /// </summary>
    public class Images
    {
        public IEnumerable<Img> Imgs { get; set; } 
    }
}
