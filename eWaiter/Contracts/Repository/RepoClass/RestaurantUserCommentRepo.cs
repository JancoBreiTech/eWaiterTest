using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class RestaurantUserCommentRepo : RepositoryBase<RestaurantUserComment>, IRestaurantUserComment
    {
        public RestaurantUserCommentRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
