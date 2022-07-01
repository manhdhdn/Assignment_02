using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessObject
{
    public partial class Member
    {
        [Required, Key]
        public int MemberId { get; set; }
        [Required, StringLength(100)]
        public string Email { get; set; } = null!;
        [Required, StringLength(40)]
        public string CompanyName { get; set; } = null!;
        [Required, StringLength(15)]
        public string City { get; set; } = null!;
        [Required, StringLength(15)]
        public string Country { get; set; } = null!;
        [Required, StringLength(30)]
        public string Password { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; } = null!;
    }
}
