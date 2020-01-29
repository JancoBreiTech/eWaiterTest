﻿using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class MenuItem
    {
        public MenuItem()
        {
            Menu = new HashSet<Menu>();
            MenuItemAllergy = new HashSet<MenuItemAllergy>();
            MenuItemIngredient = new HashSet<MenuItemIngredient>();
            MenuItemPrice = new HashSet<MenuItemPrice>();
            MenuItemSpecial = new HashSet<MenuItemSpecial>();
            OrderMenuItem = new HashSet<OrderMenuItem>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid ItemCategoryId { get; set; }
        public Guid ItemTypeId { get; set; }
        public Guid ItemStatusId { get; set; }

        public virtual ItemCategory ItemCategory { get; set; }
        public virtual ItemStatus ItemStatus { get; set; }
        public virtual ItemType ItemType { get; set; }
        public virtual ICollection<Menu> Menu { get; set; }
        public virtual ICollection<MenuItemAllergy> MenuItemAllergy { get; set; }
        public virtual ICollection<MenuItemIngredient> MenuItemIngredient { get; set; }
        public virtual ICollection<MenuItemPrice> MenuItemPrice { get; set; }
        public virtual ICollection<MenuItemSpecial> MenuItemSpecial { get; set; }
        public virtual ICollection<OrderMenuItem> OrderMenuItem { get; set; }
    }
}
