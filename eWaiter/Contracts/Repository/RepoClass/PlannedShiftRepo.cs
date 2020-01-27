using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class PlannedShiftRepo : RepositoryBase<PlannedShift>, IPlannedShift
    {
        public PlannedShiftRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
