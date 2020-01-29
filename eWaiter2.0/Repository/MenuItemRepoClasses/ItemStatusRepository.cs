using Contracts.MenuItemInterfaces;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.MenuItemRepoClasses
{
    public class ItemStatusRepository: RepositoryBase<ItemStatus>, IItemStatus
    {
        public ItemStatusRepository(eWaiterTestContext repositoryContext)
             : base(repositoryContext)
        {
        }

        public IEnumerable<ItemStatus> GetAllItemStatusses()
        {
            return FindAll()
                .OrderBy(x => x.DateActiveFrom)
                .ToList();
        }

        public ItemStatus GetItemSatusWithDetails(Guid statusId)
        {
            return FindByCondition(x => x.Id.Equals(statusId))
                    .Include(z => z.MenuItem)
                    .FirstOrDefault();
        }

        public ItemStatus GetItemStatusById(Guid statusId)
        {
            return FindByCondition(x => x.Id.Equals(statusId))
                .FirstOrDefault();
        }
    }
}
