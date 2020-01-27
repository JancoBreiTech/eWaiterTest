using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class AdvertisementRepo : RepositoryBase<Advertisement>, IAdvertisement
    {
        public AdvertisementRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
