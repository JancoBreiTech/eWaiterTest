using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Allergy
    {
        public Allergy()
        {
            MenuItemAllergy = new HashSet<MenuItemAllergy>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<MenuItemAllergy> MenuItemAllergy { get; set; }
    }
}
