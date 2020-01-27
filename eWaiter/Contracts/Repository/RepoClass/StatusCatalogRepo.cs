using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class StatusCatalogRepo : RepositoryBase<StatusCatalog>, IStatusCatalog
    {
        public StatusCatalogRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
