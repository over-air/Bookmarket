using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Model
{
    public class ProDetail
    {
        [Key]
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public string Details { get; set; }

        public virtual Product Product { get; set; }

    }
}
