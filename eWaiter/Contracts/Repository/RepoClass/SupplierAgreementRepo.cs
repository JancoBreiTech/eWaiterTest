using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class SupplierAgreementRepo : RepositoryBase<SupplierAgreement>, ISupplierAgreement
    {
        public SupplierAgreementRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
