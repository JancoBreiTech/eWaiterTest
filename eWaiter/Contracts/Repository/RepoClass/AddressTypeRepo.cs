using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class AddressTypeRepo : RepositoryBase<AddressType>, IAddressType
    {
        public AddressTypeRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
