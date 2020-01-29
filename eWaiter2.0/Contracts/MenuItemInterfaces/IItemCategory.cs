using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts.MenuItemInterfaces
{
    public interface IItemCategory: IRepositoryBase<ItemCategory>
    {
        IEnumerable<ItemCategory> GetAllItemCategories();
        ItemCategory GetItemCategoryById(Guid categoryId);
        ItemCategory GetItemCategoryWithDetails(Guid categoryId);
    }
}
