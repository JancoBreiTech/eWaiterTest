using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class IngredientRepo : RepositoryBase<Ingredient>, IIngredient
    {
        public IngredientRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
