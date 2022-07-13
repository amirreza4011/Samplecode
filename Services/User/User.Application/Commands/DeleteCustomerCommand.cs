using MediatR;
using System;

namespace Ordering.Application.Commands
{
    // User create command with string response
    public class DeleteUserCommand : IRequest<String>
    {
        public Int64 Id { get; private set; }

        public DeleteUserCommand(Int64 Id)
        {
            this.Id = Id;
        }
    }
}
