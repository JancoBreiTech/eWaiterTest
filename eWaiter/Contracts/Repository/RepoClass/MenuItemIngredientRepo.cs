using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class MenuItemIngredientRepo : RepositoryBase<MenuItemIngredient>, IMenuItemIngredient
    {
        public MenuItemIngredientRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
