using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository
{
    public interface ISupplierAddress: IRepositoryBase<SupplierAddress>
    {
        IEnumerable<SupplierAddress> SupplierByAddress(Guid supplierAddressId);
    }
}
