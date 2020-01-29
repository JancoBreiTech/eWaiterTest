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
    [Route("api/itemStatus")]
    [ApiController]
    public class ItemStatusController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;
        private IMapper _mapper;

        public ItemStatusController(ILoggerManager logger, IRepositoryWrapper repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllItemStatusses()
        {
            try
            {
                var itemStatusses = _repository.ItemStatus.GetAllItemStatusses();

                _logger.LogInfo($"Returned all item statusses from database.");

                var result = _mapper.Map<IEnumerable<ItemStatusDto>>(itemStatusses);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllItemStatusses action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetItemStatusById(Guid id)
        {
            try
            {
                var status = _repository.ItemStatus.GetItemStatusById(id);

                if (status == null)
                {
                    _logger.LogError($"Item Status with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned owner with id: {id}");

                    var result = _mapper.Map<ItemStatusDto>(status);
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
        public IActionResult GetItemStatusWithDetails(Guid id)
        {
            try
            {
                var status = _repository.ItemStatus.GetItemSatusWithDetails(id);

                if (status == null)
                {
                    _logger.LogError($"Status with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned status with details for id: {id}");

                    var result = _mapper.Map<ItemStatusDto>(status);
                    return Ok(result);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetItemStatusWithDetails action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}