using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class IngredientStockLevelRepo : RepositoryBase<IngredientStockLevel>, IIngredientStockLevel
    {
        public IngredientStockLevelRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
