using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class IngredientStockLevel
    {
        public Guid IngredientId { get; set; }
        public DateTime StockTackingDate { get; set; }
        public int QtyInStock { get; set; }

        public virtual Ingredient Ingredient { get; set; }
    }
}
