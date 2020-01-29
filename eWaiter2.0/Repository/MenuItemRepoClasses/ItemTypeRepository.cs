using Contracts.MenuItemInterfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.MenuItemRepoClasses
{
    public class ItemTypeRepository: RepositoryBase<ItemType>, IItemType
    {
        public ItemTypeRepository(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<ItemType> GetAllItemTypes()
        {
            return FindAll()
                .OrderBy(x => x.Description)
                .ToList();
        }

        public ItemType GetItemTypeById(Guid typeId)
        {
            return FindByCondition(x => x.Id.Equals(typeId))
                .FirstOrDefault();
        }

        public ItemType GetItemTypeWithDetails(Guid typeId)
        {
            return FindByCondition(x => x.Id.Equals(typeId))
                    .Include(z => z.MenuItem)
                    .FirstOrDefault();
        }
    }
}
