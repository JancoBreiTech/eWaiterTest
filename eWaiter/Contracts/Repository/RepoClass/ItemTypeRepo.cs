using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class ItemTypeRepo : RepositoryBase<ItemType>, IItemType
    {
        public ItemTypeRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
