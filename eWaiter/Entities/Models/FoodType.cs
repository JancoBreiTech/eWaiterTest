using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class FoodType
    {
        public FoodType()
        {
            RestaurantType = new HashSet<RestaurantType>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<RestaurantType> RestaurantType { get; set; }
    }
}
