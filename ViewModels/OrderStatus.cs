namespace ViewModels
{
    /// <summary>
    /// 订单状态枚举
    /// </summary>
    public enum OrderStatus:int
    {
        /// <summary>
        /// 表示订单的已创建状态 - 放入购物车。
        /// </summary>
        Created = 0,

        /// <summary>
        /// 订单已提交，生成最终订单
        /// </summary>
        Submit, 

        /// <summary>
        /// 表示销售订单的已付款状态 - 暂时不使用在线付款
        /// </summary>
        Paid,

        /// <summary>
        /// 派送状态
        /// </summary>
        Send,

        /// <summary>
        /// 已收货
        /// </summary>
        Receive,

        /// <summary>
        /// 待评价
        /// </summary>
        Review,

        /// <summary>
        /// 交易结束
        /// </summary>
        Over
    }
}
