using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class MenuRepo : RepositoryBase<Menu>, IMenu
    {
        public MenuRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
