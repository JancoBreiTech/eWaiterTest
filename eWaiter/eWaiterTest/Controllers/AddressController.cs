using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Entities;
using Entities.DataTransferObject;
using Entities.DataTransferObject.AddressDtos;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eWaiterTest.Controllers
{
    [Route("api/address")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;
        private IMapper _mapper;

        public AddressController(ILoggerManager logger, IRepositoryWrapper repository, IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllAddresses()
        {
            try
            {
                var addresses = _repository.Address.GetAllAddresses();

                _logger.LogInfo($"Returned all addresses from database.");

                var addressesResult = _mapper.Map<IEnumerable<AddressDto>>(addresses);
                return Ok(addressesResult);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAllAddresses action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id}", Name = "AddressById")]
        public IActionResult GetAddressById(Guid id)
        {
            try
            {
                var address = _repository.Address.GetAddressById(id);

                if (address == null)
                {
                    _logger.LogError($"Address with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                else
                {
                    _logger.LogInfo($"Returned address with id: {id}");

                    var addressResult = _mapper.Map<AddressDto>(address);
                    return Ok(addressResult);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetAddressById action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        public IActionResult CreateAddress ([FromBody]AddressForCreationDto address)
        {
            try
            {
                if (address == null)
                {
                    _logger.LogError("Address object sent from client is null.");
                    return BadRequest("Address object is null");
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid address object sent from client.");
                    return BadRequest("Invalid model object");
                }

                var addressEntity = _mapper.Map<Address>(address);

                _repository.Address.CreateAddress(addressEntity);
                _repository.Save();

                var createdAddress = _mapper.Map<AddressDto>(addressEntity);

                return CreatedAtRoute("AddressById", new { id = createdAddress.Id }, createdAddress);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside CreateAddress action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }

        }

        [HttpPut("{id}")]
        public IActionResult UpdateAddress(Guid id, [FromBody]AddressForUpdateDto address)
        {
            try
            {
                if (address == null)
                {
                    _logger.LogError("Address object sent from client is null.");
                    return BadRequest("Address object is null");
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogError("Invalid address object sent from client.");
                    return BadRequest("Invalid model object");
                }

                var addressEntity = _repository.Address.GetAddressById(id);
                if (addressEntity == null)
                {
                    _logger.LogError($"Address with id: {id}, hasn't been found in db.");
                    return NotFound();
                }

                _mapper.Map(address, addressEntity);

                _repository.Address.UpdateAddress(addressEntity);
                _repository.Save();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside UpdateAddress action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAddress(Guid id)
        {
            try
            {
                var address = _repository.Address.GetAddressById(id);
                if (address == null)
                {
                    _logger.LogError($"Address with id: {id}, hasn't been found in db.");
                    return NotFound();
                }

                if (_repository.SupplierAddress.SupplierByAddress(id).Any())
                {
                    _logger.LogError($"Cannot delete Address with id: {id}. It has related supplierAddress. Delete those accounts first");
                    return BadRequest("Cannot delete address. It has related supplierAddress. Delete those accounts first");
                }

                _repository.Address.DeleteAddress(address);
                _repository.Save();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside DeleteAddress action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}