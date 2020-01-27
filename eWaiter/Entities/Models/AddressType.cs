using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class AddressType
    {
        public AddressType()
        {
            SupplierAddress = new HashSet<SupplierAddress>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<SupplierAddress> SupplierAddress { get; set; }
    }
}
