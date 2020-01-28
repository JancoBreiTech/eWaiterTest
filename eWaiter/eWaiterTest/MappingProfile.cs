using AutoMapper;
using Entities.Models;
using Entities.DataTransferObject;
using Entities.DataTransferObject.AddressDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eWaiterTest
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Restaurant, RestaurantDto>();

            CreateMap<Address, AddressDto>();
            CreateMap<Restaurant, RestaurantDto>();

            CreateMap<AddressForCreationDto, Address>();
            CreateMap<Address, AddressDto>();

            CreateMap<AddressForUpdateDto, Address>();

        }
    }
}
