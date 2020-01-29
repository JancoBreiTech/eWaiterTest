using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Advertisement
    {
        public Advertisement()
        {
            Restaurant = new HashSet<Restaurant>();
        }

        public Guid Id { get; set; }
        public DateTime DateActiveFrom { get; set; }
        public DateTime DateActiveTo { get; set; }
        public decimal Price { get; set; }
        public byte[] AdvFile { get; set; }
        public string TargetAudience { get; set; }

        public virtual ICollection<Restaurant> Restaurant { get; set; }
    }
}
