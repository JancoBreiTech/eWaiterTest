using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class RestaurantImgRepo : RepositoryBase<RestaurantImg>, IRestaurantImg
    {
        public RestaurantImgRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
