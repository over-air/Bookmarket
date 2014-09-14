namespace Models.Model
{
    public class Address
    {
        public int ID { get; set; }

        /// <summary>
        /// 订单详细地址（校内详细地址，不与人名挂钩）
        /// </summary>
        public string Addr { get; set; }



        /// <summary>
        /// 外键
        /// </summary>
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public virtual Order Order { get; set; }

    }
}
