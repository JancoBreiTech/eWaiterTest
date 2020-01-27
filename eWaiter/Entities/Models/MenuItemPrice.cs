using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class MenuItemPrice
    {
        public Guid Id { get; set; }
        public DateTime DateFrom { get; set; }
        public decimal Price { get; set; }
        public Guid MenuItemId { get; set; }

        public virtual MenuItem MenuItem { get; set; }
    }
}
