using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class RestaurantFacilityRepo : RepositoryBase<RestaurantFacility>, IRestaurantFacility
    {
        public RestaurantFacilityRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
