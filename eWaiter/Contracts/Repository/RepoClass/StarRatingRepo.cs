using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class StarRatingRepo : RepositoryBase<StarRating>, IStarRating
    {
        public StarRatingRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
