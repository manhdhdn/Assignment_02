using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObject
{
    public partial class Order
    {
        [Required, Key]
        public int OrderId { get; set; }
        [Required, ForeignKey("Members")]
        public int MemberId { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime OrderDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? RequiredDate { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime? ShippedDate { get; set; }
        public decimal? Freight { get; set; }

        public virtual Member Member { get; set; } = null!;
        public virtual ICollection<OrderDetail> OrderDetails { get; set; } = null!;
    }
}
