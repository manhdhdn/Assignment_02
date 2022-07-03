using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject
{
    public partial class OrderDetail
    {
        [Required, Key, ForeignKey("Orders")]
        public int OrderId { get; set; }
        [Required, ForeignKey("Products")]
        public int ProductId { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double Discount { get; set; }
    }
}
