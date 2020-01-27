using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class OrderStatusRepo : RepositoryBase<OrderStatus>, IOrderStatus
    {
        public OrderStatusRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
