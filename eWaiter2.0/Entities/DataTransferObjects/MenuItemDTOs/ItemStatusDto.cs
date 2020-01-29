using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects.MenuItemDTOs
{
    public class ItemStatusDto
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime? DateActiveFrom { get; set; }
        public DateTime? DateActiveTo { get; set; }

        public IEnumerable<MenuItemDto> MenuItems { get; set; }

    }
}
