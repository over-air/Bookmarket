using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Models;
using Models.Model;

namespace BLL
{
    public class OrderManage:IOrderManage
    {
        BookContext db=new BookContext();

        public void OrderInsert(Orderinfo orderinfo)
        {
            db.Orderinfos.Add(orderinfo);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                var a = "sd";
            }
        }

        public void SubmitOrder(int addressId, IEnumerable<Orderinfo> orderinfos)
        {
            
        }

    }
}
