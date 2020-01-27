using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class MenuItemAllergyRepo : RepositoryBase<MenuItemAllergy>, IMenuItemAllergy
    {
        public MenuItemAllergyRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
