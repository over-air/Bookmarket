namespace Models.Model
{
    public class BookMajor
    {
        public int ProductId { get; set; }

        public int MajorId { get; set; }

        public virtual Product Product { get; set; }

        public virtual Major Major { get; set; }
    }
}
