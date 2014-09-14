using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Institute
    {
        public int Id { get; set; }

        /// <summary>
        /// 学院名称
        /// </summary>
        public string Name { get; set; }

        public virtual ICollection<Major> Majors { get; set; } 

    }
}
