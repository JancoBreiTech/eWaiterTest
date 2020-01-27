using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class ReorderFrequencyRepo : RepositoryBase<ReorderFrequency>, IReorderFrequency
    {
        public ReorderFrequencyRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
