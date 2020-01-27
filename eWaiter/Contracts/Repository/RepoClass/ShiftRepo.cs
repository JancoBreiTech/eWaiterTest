using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class ShiftRepo : RepositoryBase<Shift>, IShift
    {
        public ShiftRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
