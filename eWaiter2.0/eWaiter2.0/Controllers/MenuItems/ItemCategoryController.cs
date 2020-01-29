using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Contracts;
using Entities.DataTransferObjects.MenuItemDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eWaiter2._0.Controllers.MenuItems
{
    [Route("api/itemCategory")]
    [ApiController]
    public class ItemCategoryController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;
        private IMapper _mapper;

        public ItemCategoryController(ILoggerManager logger, IRepositoryWrapper repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllItemCategories()
        {
            try
            {
                var categories = _repository.ItemCategory.GetAllItemCategories();

                _logger.LogInfo($"Returned all item categories from database.");

                var categoriesResult = _mapper.Map<IEnumerable<ItemCategoryDto>>(categories);
                return Ok(categoriesResult);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllItemCategories action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetItemCategoryById(Guid id)
        {
            try
            {
                var category = _repository.ItemCategory.GetItemCategoryById(id);

                if (category == null)
                {
                    _logger.LogError($"Category with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned category with id: {id}");

                    var result = _mapper.Map<ItemCategoryDto>(category);
                    return Ok(result);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetCategoryById action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpGet("{id}/menuItem")]
        public IActionResult GetItemCategoryWithDetails(Guid id)
        {
            try
            {
                var category = _repository.ItemCategory.GetItemCategoryWithDetails(id);                    

                if (category == null)
                {
                    _logger.LogError($"Category with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned owner with details for id: {id}");
                    //not working:AutoMapper
                    var result = _mapper.Map<ItemCategoryDto>(category);
                    return Ok(result);//should use result
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetItemCategoryWithDetails action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}