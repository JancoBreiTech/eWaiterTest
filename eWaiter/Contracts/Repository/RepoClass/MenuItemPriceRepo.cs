using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class MenuItemPriceRepo : RepositoryBase<MenuItemPrice>, IMenuItemPrice
    {
        public MenuItemPriceRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
