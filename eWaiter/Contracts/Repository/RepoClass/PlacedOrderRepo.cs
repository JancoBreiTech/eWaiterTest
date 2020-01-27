using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class PlacedOrderRepo : RepositoryBase<PlacedOrder>, IPlacedOrder
    {
        public PlacedOrderRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
