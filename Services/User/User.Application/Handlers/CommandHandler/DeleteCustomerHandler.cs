using MediatR;
using Ordering.Application.Commands;
using Ordering.Core.Repositories.Command;
using Ordering.Core.Repositories.Query;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ordering.Application.Handlers.CommandHandler
{
    // User delete command handler with string response as output
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, String>
    {
        private readonly IUserCommandRepository _UserCommandRepository;
        private readonly IUserQueryRepository _UserQueryRepository;
        public DeleteUserHandler(IUserCommandRepository UserRepository, IUserQueryRepository UserQueryRepository)
        {
            _UserCommandRepository = UserRepository;
            _UserQueryRepository = UserQueryRepository;
        }

        public async Task<string> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var UserEntity = await _UserQueryRepository.GetByIdAsync(request.Id);

                await _UserCommandRepository.DeleteAsync(UserEntity);
            }
            catch(Exception exp)
            {
                throw (new ApplicationException(exp.Message));
            }

            return "User information has been deleted!";
        }
    }
}
