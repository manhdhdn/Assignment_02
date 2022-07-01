using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessObject
{
    public partial class Product
    {
        [Required, Key]
        public int ProductId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required, StringLength(40)]
        public string ProductName { get; set; } = null!;
        [Required, StringLength(20)]
        public string Weight { get; set; } = null!;
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public int UnitInStock { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = null!;
    }
}
