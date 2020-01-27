using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class FacilityRepo : RepositoryBase<Facility>, IFacility
    {
        public FacilityRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
