﻿using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class IngredientType
    {
        public IngredientType()
        {
            Ingredient = new HashSet<Ingredient>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Ingredient> Ingredient { get; set; }
    }
}
