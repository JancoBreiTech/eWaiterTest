using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class StaffShiftRepo : RepositoryBase<StaffShift>, IStaffShift
    {
        public StaffShiftRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
