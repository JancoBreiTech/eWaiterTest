using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects.MenuItemDTOs
{
    public class MenuDto
    {
        public DateTime? DateActiveFrom { get; set; }
        public DateTime? DateActiveTo { get; set; }
        public string Description { get; set; }
        //This will be added with MenuItem Repo etc
        public string MenuName { get; set; }
    }
}
