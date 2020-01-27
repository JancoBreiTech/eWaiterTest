using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class IngredientSupplierRepo : RepositoryBase<IngredientSupplier>, IIngredientSupplier
    {
        public IngredientSupplierRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
