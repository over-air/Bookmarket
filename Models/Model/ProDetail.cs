namespace Models.Model
{
    public class ProDetail
    {
        public int ProductId { get; set; }

        public string Details { get; set; }

        public virtual Product Product { get; set; }

    }
}
