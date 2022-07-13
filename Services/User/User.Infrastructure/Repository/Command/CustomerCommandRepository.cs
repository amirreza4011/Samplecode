using Ordering.Core.Entities;
using Ordering.Core.Repositories.Command;
using Ordering.Infrastructure.Data;
using Ordering.Infrastructure.Repository.Command.Base;

namespace Ordering.Infrastructure.Repository.Command
{
    // Command Repository class for User
    public class UserCommandRepository : CommandRepository<user>, IUserCommandRepository
    {
        public UserCommandRepository(OrderingContext context) : base(context)
        {

        }
    }
}
