using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class CreateOrderForIngredientRepo : RepositoryBase<CreateOrderForIngredient>, ICreateOrderForIngredient
    {
        public CreateOrderForIngredientRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
