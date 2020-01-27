using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class AllergyRepo : RepositoryBase<Allergy>, IAllergy
    {
        public AllergyRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
