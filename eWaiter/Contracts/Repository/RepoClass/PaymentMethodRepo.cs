using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class PaymentMethodRepo : RepositoryBase<PaymentMethod>, IPaymentMethod
    {
        public PaymentMethodRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
