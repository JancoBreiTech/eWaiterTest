using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class StaffRoleRepo : RepositoryBase<StaffRole>, IStaffRole
    {
        public StaffRoleRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
