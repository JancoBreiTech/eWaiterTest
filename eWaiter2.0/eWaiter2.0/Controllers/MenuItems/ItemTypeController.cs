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
    [Route("api/itemType")]
    [ApiController]
    public class ItemTypeController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;
        private IMapper _mapper;

        public ItemTypeController(ILoggerManager logger, IRepositoryWrapper repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllItemTypes()
        {
            try
            {
                var types = _repository.ItemType.GetAllItemTypes();

                _logger.LogInfo($"Returned all item types from database.");

                var result = _mapper.Map<IEnumerable<ItemTypeDto>>(types);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllItemTypes action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetItemTypeById(Guid id)
        {
            try
            {
                var type = _repository.ItemType.GetItemTypeById(id);

                if (type == null)
                {
                    _logger.LogError($"Type with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned type with id: {id}");

                    var result = _mapper.Map<ItemTypeDto>(type);
                    return Ok(result);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetOwnerById action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpGet("{id}/menuItem")]
        public IActionResult GetItemTypeWithDetails(Guid id)
        {
            try
            {
                var type = _repository.ItemType.GetItemTypeWithDetails(id);

                if (type == null)
                {
                    _logger.LogError($"Type with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned type with details for id: {id}");

                    var result = _mapper.Map<ItemTypeDto>(type);
                    return Ok(result);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetItemTypeWithDetails action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}