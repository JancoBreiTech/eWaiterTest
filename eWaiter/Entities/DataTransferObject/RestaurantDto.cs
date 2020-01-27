using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Entities.DataTransferObject
{
    public class RestaurantDto
    {
        public Guid Id { get; set; }
        public Guid AddressId { get; set; }
        public Guid AdvertisementId { get; set; }
        public Guid ImageId { get; set; }
        public string Website { get; set; }
        public string SocialMediaAddress { get; set; }

        public virtual AddressDto Address { get; set; }


    }
}
