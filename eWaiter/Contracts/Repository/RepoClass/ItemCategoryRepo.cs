using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class ItemCategoryRepo : RepositoryBase<ItemCategory>, IItemCategory
    {
        public ItemCategoryRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
