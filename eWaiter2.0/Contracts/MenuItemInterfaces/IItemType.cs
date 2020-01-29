using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.MenuItemInterfaces
{
    public interface IItemType:IRepositoryBase<ItemType>
    {
        IEnumerable<ItemType> GetAllItemTypes();
        ItemType GetItemTypeById(Guid typeId);
        ItemType GetItemTypeWithDetails(Guid typeId);
    }
}
