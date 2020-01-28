using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class SupplierAddressRepo : RepositoryBase<SupplierAddress>, ISupplierAddress
    {
        public SupplierAddressRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<SupplierAddress> SupplierByAddress(Guid supplierAddressId)
        {
            return FindByCondition(s => s.AddressId.Equals(supplierAddressId)).ToList();
        }
    }
}
