using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class RestaurantRepo : RepositoryBase<Restaurant>, IRestaurant
    {
        public RestaurantRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            return FindAll()
                .OrderBy(r => r.Website)
                .ToList();
        }

        public Restaurant GetRestaurantById(Guid restaurantId)
        {
            return FindByCondition(r => r.Id.Equals(restaurantId))
                .FirstOrDefault();
        }

        public Restaurant GetRestaurantWithDetails(Guid restaurantId)
        {
            return FindByCondition(r => r.Id.Equals(restaurantId))
                .Include(a => a.Address)
                .FirstOrDefault();
        }
    }
}
