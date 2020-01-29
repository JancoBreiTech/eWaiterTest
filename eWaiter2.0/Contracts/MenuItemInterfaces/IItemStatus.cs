using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.MenuItemInterfaces
{
    public interface IItemStatus: IRepositoryBase<ItemStatus>
    {
        IEnumerable<ItemStatus> GetAllItemStatusses();
        ItemStatus GetItemStatusById(Guid statusId);
        ItemStatus GetItemSatusWithDetails(Guid statusId);
    }
}
