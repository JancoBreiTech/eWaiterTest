using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class AddressRepo : RepositoryBase<Address>, IAddress
    {
        public AddressRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
