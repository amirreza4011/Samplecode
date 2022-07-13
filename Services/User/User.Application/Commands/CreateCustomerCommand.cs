using MediatR;
using Ordering.Application.Response;
using System;

namespace Ordering.Application.Commands
{
    // User create command with UserResponse
    public class CreateUserCommand : IRequest<UserResponse>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedDate { get; set; }

        public CreateUserCommand()
        {
            this.CreatedDate = DateTime.Now;
        }
    }
}
