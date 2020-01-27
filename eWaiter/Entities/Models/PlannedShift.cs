﻿using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class PlannedShift
    {
        public PlannedShift()
        {
            Shift = new HashSet<Shift>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Description { get; set; }

        public virtual ICollection<Shift> Shift { get; set; }
    }
}
