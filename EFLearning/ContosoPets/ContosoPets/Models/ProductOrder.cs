using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoPets.Models
{
    // Intersection table
    // facilitates many-to-many relationship
    public class ProductOrder
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; } // Navigation property
        public Product Product { get; set; } // Navigation property
    }
}
