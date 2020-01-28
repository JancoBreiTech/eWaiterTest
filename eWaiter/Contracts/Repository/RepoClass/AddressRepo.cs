using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class AddressRepo : RepositoryBase<Address>, IAddress
    {
        public AddressRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public void CreateAddress(Address address)
        {
            Create(address);
        }

        public void DeleteAddress(Address address)
        {
            Delete(address);
        }

        public Address GetAddressById(Guid addressId)
        {
            return FindByCondition(a => a.Id.Equals(addressId))
                .FirstOrDefault();
        }

        public IEnumerable<Address> GetAllAddresses()
        {
            return FindAll()
                .OrderBy(a => a.City)
                .ToList();
        }

        public void UpdateAddress(Address address)
        {
            Update(address);
        }
    }
}
