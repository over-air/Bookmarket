using Models;

namespace IDAL
{
    public interface IOrder
    {
        /// <summary>
        /// 插入订单详情
        /// </summary>
        /// <param name="order"></param>
        void Insert(Orderinfo order);

        Orderinfo GetOrder(int orderinfoId);
        
    }
}
