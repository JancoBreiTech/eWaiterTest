using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class ItemStatusRepo : RepositoryBase<ItemStatus>, IItemStatus
    {
        public ItemStatusRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
