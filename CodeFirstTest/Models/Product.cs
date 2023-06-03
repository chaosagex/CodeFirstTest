using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstTest.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "decimal(18,5)")]
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public List<InvoiceProduct> Invoices { get; set; }
    }
}
