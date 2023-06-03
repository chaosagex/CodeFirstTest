using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstTest.Models
{
    [PrimaryKey("ProductID", "InvoiceID")]
    public class InvoiceProduct
    {

        public int ProductID { get; set; }
        [ForeignKey("ProductID")]
        public Product Product { get; set; }

        public int InvoiceID { get; set; }
        [ForeignKey("InvoiceID")]
        public Invoice Invoice { get; set; }

        public int Quantity { get; set; }
    }
}
