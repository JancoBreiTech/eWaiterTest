using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class AgreementSupplierRepo : RepositoryBase<AgreementSupplier>, IAgreementSupplier
    {
        public AgreementSupplierRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
