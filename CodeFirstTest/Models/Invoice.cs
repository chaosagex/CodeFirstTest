using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstTest.Models
{
    public class Invoice
    {
        [Key]
        public int ID { get; set; }
        public DateTime OrderTime { get; set; }
        [Column(TypeName = "decimal(18,5)")]
        public decimal TotalAmount { get; set; }
        public List<InvoiceProduct> Products { get; set; }
    }
}
