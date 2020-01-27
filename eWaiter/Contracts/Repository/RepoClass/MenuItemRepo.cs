using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class MenuItemRepo : RepositoryBase<MenuItem>, IMenuItem
    {
        public MenuItemRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
