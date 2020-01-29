using Contracts.MenuItemInterfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IMenuItem MenuItem { get; }
        IItemType ItemType { get; }
        IItemCategory ItemCategory { get; }
        IItemStatus ItemStatus { get; }
        void Save();
    }
}
