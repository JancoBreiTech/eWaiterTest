using Contracts.MenuItemInterfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.MenuItemRepoClasses
{
    public class MenuItemRepository: RepositoryBase<MenuItem>, IMenuItem
    {
        public MenuItemRepository(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
