using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            Menu = new HashSet<Menu>();
            RestaurantFacility = new HashSet<RestaurantFacility>();
            RestaurantSeating = new HashSet<RestaurantSeating>();
            RestaurantType = new HashSet<RestaurantType>();
            Staff = new HashSet<Staff>();
        }

        public Guid Id { get; set; }
        public Guid AddressId { get; set; }
        public Guid AdvertisementId { get; set; }
        public Guid ImageId { get; set; }
        public string Website { get; set; }
        public string SocialMediaAddress { get; set; }

        public virtual Address Address { get; set; }
        public virtual Advertisement Advertisement { get; set; }
        public virtual RestaurantImg Image { get; set; }
        public virtual ICollection<Menu> Menu { get; set; }
        public virtual ICollection<RestaurantFacility> RestaurantFacility { get; set; }
        public virtual ICollection<RestaurantSeating> RestaurantSeating { get; set; }
        public virtual ICollection<RestaurantType> RestaurantType { get; set; }
        public virtual ICollection<Staff> Staff { get; set; }
    }
}
