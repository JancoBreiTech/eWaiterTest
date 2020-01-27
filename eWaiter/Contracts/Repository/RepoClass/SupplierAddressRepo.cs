using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class SupplierAddressRepo : RepositoryBase<SupplierAddress>, ISupplierAddress
    {
        public SupplierAddressRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
