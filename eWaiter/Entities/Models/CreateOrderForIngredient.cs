using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class CreateOrderForIngredient
    {
        public Guid IngredientId { get; set; }
        public DateTime OrderDate { get; set; }
        public int QtyInOrder { get; set; }

        public virtual Ingredient Ingredient { get; set; }
    }
}
