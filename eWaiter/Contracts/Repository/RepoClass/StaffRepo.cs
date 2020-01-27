using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class StaffRepo : RepositoryBase<Staff>, IStaff
    {
        public StaffRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
