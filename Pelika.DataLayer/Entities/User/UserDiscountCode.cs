using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Pelika.DataLayer.Entities.Order;

namespace Pelika.DataLayer.Entities.User
{
    public class UserDiscountCode
    {
        [Key]
        public int UDId { get; set; }
        public int UserId { get; set; }
        public int DiscountId { get; set; }

        public User User { get; set; }
        public Discount Discount { get; set; }

    }
}
