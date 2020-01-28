using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository
{
    public interface IAddress : IRepositoryBase<Address>
    {
        IEnumerable<Address> GetAllAddresses();
        Address GetAddressById(Guid addressId);
        void CreateAddress(Address address);
        void UpdateAddress(Address address);
        void DeleteAddress(Address address);
    }
}
