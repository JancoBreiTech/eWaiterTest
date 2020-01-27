using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class FoodTypeRepo : RepositoryBase<FoodType>, IFoodType
    {
        public FoodTypeRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
