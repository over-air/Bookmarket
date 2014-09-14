using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ProDetail
    {
        public int ProductId { get; set; }

        public string Details { get; set; }

        public virtual Product Product { get; set; }

    }
}
