using Contracts.MenuItemInterfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.MenuItemRepoClasses
{
    public class ItemCategoryRepository: RepositoryBase<ItemCategory>, IItemCategory
    {
        public ItemCategoryRepository(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<ItemCategory> GetAllItemCategories()
        {
            return FindAll()
                .OrderBy(ic => ic.Description)
                .ToList();
        }

        //Can Add Find By description same way
        public ItemCategory GetItemCategoryById(Guid categoryId)
        {
            return FindByCondition(x => x.Id.Equals(categoryId))
                .FirstOrDefault();
        }

        public ItemCategory GetItemCategoryWithDetails(Guid categoryId)
        {
            return FindByCondition(x=>x.Id == categoryId)
                    .Include(z=>z.MenuItem)
                    .FirstOrDefault();
        }
    }
}
