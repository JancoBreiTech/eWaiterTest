using AutoMapper;
using Entities.DataTransferObjects.MenuItemDTOs;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eWaiter2._0
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<ItemCategory, ItemCategoryDto>();
            CreateMap<ItemType, ItemTypeDto>();
            CreateMap<ItemStatus, ItemStatusDto>();

            CreateMap<MenuItem, MenuItemDto>();
            //CreateMap<ItemCategory, ItemCategoryDto>();
            //CreateMap<ItemType, ItemTypeDto>();
            //CreateMap<ItemStatus, ItemStatusDto>();

            CreateMap<ItemCategory, ItemCategoryDto>()
            .ForMember(x => x.MenuItem, x => x.MapFrom(src => src.MenuItem));

        }

       
    }
}
