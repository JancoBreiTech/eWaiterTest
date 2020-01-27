using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class UserTableBookingRepo : RepositoryBase<UserTableBooking>, IUserTableBooking
    {
        public UserTableBookingRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
