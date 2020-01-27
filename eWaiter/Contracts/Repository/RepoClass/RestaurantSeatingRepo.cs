using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class RestaurantSeatingRepo : RepositoryBase<RestaurantSeating>, IRestaurantSeating
    {
        public RestaurantSeatingRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
