using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.ModelBinding;
using IBLL;
using Models;
using Models.Model;

namespace BLL
{
    public class OrderManage:IOrderManage
    {
        BookContext db=new BookContext();

        /// <summary>
        /// 加入购物车(顺利返回插入id)
        /// </summary>
        /// <param name="orderinfo"></param>
        public int OrderInsert(Orderinfo orderinfo)
        {
            db.Orderinfos.Add(orderinfo);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                BLL.Common.ReportEx(HttpContext.Current.Request.Url.AbsolutePath,"加入购物车"+ex.Message,HttpContext.Current.Session["userid"].ToString());
                return 0;
            }
            return orderinfo.Id;
        }

        /// <summary>
        /// 提交订单(新建订单order，更新orderinfo)
        /// </summary>
        public int SubmitOrder(int addressId,int sendtime, IEnumerable<Orderinfo> orderinfos)
        {
            var order = new Order()
            {
                AddressId = addressId,
                Dtime = DateTime.Now,
                SendTime = (SendTime) Enum.Parse(typeof (SendTime), sendtime.ToString())
            };
            db.Orders.Add(order);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex1)
            {
                BLL.Common.ReportEx(HttpContext.Current.Request.Url.AbsolutePath, "新建订单order" + ex1.Message, HttpContext.Current.Session["userid"].ToString());
                return 0;
            }
            foreach (var orderinfo in orderinfos)
            {
                orderinfo.OrderId = order.Id;
                orderinfo.Status = OrderStatus.Submit;
            }
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex2)
            {
                BLL.Common.ReportEx(HttpContext.Current.Request.Url.AbsolutePath, "生成订单，更新orderinfo状态" + ex2.Message, HttpContext.Current.Session["userid"].ToString());
                db.Orders.Remove(order);//删除订单信息
                return 0;
            }
            return order.Id;
        }
    }
}
