using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class IngredientTypeRepo : RepositoryBase<IngredientType>, IIngredientType
    {
        public IngredientTypeRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
