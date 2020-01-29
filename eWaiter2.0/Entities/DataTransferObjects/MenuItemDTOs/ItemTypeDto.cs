using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects.MenuItemDTOs
{
    public class ItemTypeDto
    {
        public Guid Id { get; set; }
        public string Description { get; set; }

        public IEnumerable<MenuItemDto> MenuItems { get; set; }

    }
}
