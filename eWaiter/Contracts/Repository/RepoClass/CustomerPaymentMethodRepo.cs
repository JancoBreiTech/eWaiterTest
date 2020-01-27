using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class CustomerPaymentMethodRepo : RepositoryBase<CustomerPaymentMethod>, ICustomerPaymentMethod
    {
        public CustomerPaymentMethodRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
