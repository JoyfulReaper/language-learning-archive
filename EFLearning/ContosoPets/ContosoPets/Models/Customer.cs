using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoPets.Models
{
    public class Customer
    {
#nullable enable
        public int Id { get; set; }
        public string FirstName { get; set; } // null not allowed
        public string LastName { get; set; } // null not allowed
        public string? Address { get; set; } // Allows nulls
        public string? Phone { get; set; } // Allows nulls
        public string? Email { get; set; }
#nullable disable
        public ICollection<Order> Orders { get; set; } // Navigation property (one to many, 0 or more orders)
    }
}
