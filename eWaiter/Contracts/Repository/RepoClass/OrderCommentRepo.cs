using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Repository.RepoClass
{
    public class OrderCommentRepo : RepositoryBase<OrderComment>, IOrderComment
    {
        public OrderCommentRepo(eWaiterTestContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
