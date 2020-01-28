using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Entities;
using Entities.DataTransferObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eWaiterTest.Controllers
{
    [Route("api/restaurant")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;
        private IMapper _mapper;

        public RestaurantController(ILoggerManager logger, IRepositoryWrapper repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllOwners()
        {
            try
            {
                var restaurants = _repository.Restaurant.GetAllRestaurants();

                _logger.LogInfo($"Returned all restaurants from database.");

                var restaurantsResult = _mapper.Map<IEnumerable<RestaurantDto>>(restaurants);
                return Ok(restaurantsResult);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllRestaurants action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}", Name ="OwnerById")]
        public IActionResult GetOwnerById(Guid id)
        {
            try
            {
                var restaurant = _repository.Restaurant.GetRestaurantById(id);

                if (restaurant == null)
                {
                    _logger.LogError($"Restaurant with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned restaurant with id: {id}");

                    var restaurantResult = _mapper.Map<RestaurantDto>(restaurant);
                    return Ok(restaurantResult);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetRestaurantById action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}/address")]
        public IActionResult GetRestaurantWithDetails(Guid id)
        {
            try
            {
                var restaurant = _repository.Restaurant.GetRestaurantWithDetails(id);

                if (restaurant == null)
                {
                    _logger.LogError($"Restaurant with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned restaurant with details for id: {id}");

                    var restaurantResult = _mapper.Map<RestaurantDto>(restaurant);
                    return Ok(restaurantResult);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetRestaurantWithDetails action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}