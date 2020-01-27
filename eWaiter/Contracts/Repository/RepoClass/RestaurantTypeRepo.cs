using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class RestaurantTypeRepo : RepositoryBase<RestaurantType>, IRestaurantType
    {
        public RestaurantTypeRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
