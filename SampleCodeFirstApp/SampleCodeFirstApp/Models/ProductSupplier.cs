using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCodeFirstApp.Models
{
    public  class ProductSupplier
    {
        [Key]
        public int InvoiceNumber { get; set; }
        public int ProductId { get; set; }
        public int SupplerId { get; set; }
        public DateTime SupplyDate { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("SupplerId")]
        public Supplier Supplier { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

    }
}
