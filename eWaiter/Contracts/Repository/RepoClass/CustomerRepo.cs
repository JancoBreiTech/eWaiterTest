using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class CustomerRepo : RepositoryBase<Customer>, ICustomer
    {
        public CustomerRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
