using System.ComponentModel.DataAnnotations;

namespace Models.Model
{
    public class ProDetail
    {
        [Key]
        public int ProductId { get; set; }

        public string Details { get; set; }

        public virtual Product Product { get; set; }

    }
}
