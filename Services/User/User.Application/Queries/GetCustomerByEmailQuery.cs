using MediatR;
using Ordering.Core.Entities;

namespace Ordering.Application.Queries
{
    // User GetUserByEmailQuery with User response
    public class GetUserByEmailQuery: IRequest<user>
    {
        public string Email { get; private set; }
        
        public GetUserByEmailQuery(string email)
        {
            this.Email = email;
        }

    }
}
