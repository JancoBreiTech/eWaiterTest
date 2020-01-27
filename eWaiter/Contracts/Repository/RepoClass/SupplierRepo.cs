using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class SupplierRepo : RepositoryBase<Supplier>, ISupplier
    {
        public SupplierRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
