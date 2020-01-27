using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class OrderTableRepo : RepositoryBase<OrderTable>, IOrderTable
    {
        public OrderTableRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
