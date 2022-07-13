using MediatR;
using Ordering.Application.Response;
using System;

namespace Ordering.Application.Commands
{
    // User create command with UserResponse
    public class EditUserCommand : IRequest<UserResponse>
    {

        public Int64 Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
    }
}
