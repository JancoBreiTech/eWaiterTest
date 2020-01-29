using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class RestaurantType
    {
        public Guid RestaurantId { get; set; }
        public Guid FoodTypeId { get; set; }

        public virtual FoodType FoodType { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
