using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class SpecialRepo : RepositoryBase<Special>, ISpecial
    {
        public SpecialRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
