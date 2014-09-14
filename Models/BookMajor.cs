using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class BookMajor
    {
        public int ProductID { get; set; }

        public int MajorID { get; set; }

        public virtual Product Product { get; set; }

        public virtual Major Major { get; set; }
    }
}
