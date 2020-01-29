using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects.MenuItemDTOs
{
    public class ItemCategoryDto
    {

        public Guid Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<MenuItemDto> MenuItem { get; set; }
    }
}
