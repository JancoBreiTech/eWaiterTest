using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class OrderMenuItemRepo : RepositoryBase<OrderMenuItem>, IOrderMenuItem
    {
        public OrderMenuItemRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
