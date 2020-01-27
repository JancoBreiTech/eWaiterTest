using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class SeatingRepo : RepositoryBase<Seating>, ISeating
    {
        public SeatingRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
