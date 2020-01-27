using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class RestaurantImg
    {
        public RestaurantImg()
        {
            Restaurant = new HashSet<Restaurant>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public byte[] ImageFile { get; set; }

        public virtual ICollection<Restaurant> Restaurant { get; set; }
    }
}
