using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class MenuItemSpecialRepo : RepositoryBase<MenuItemSpecial>, IMenuItemSpecial
    {
        public MenuItemSpecialRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
