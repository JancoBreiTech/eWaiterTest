using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository
{
    public interface IRestaurant : IRepositoryBase<Restaurant>
    {
        IEnumerable<Restaurant> GetAllRestaurants();
        Restaurant GetRestaurantById(Guid restaurantId);
        Restaurant GetRestaurantWithDetails(Guid restaurantId);
    }
}
