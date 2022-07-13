using MediatR;
using Ordering.Application.Commands;
using Ordering.Application.Mapper;
using Ordering.Application.Response;
using Ordering.Core.Entities;
using Ordering.Core.Repositories.Command;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ordering.Application.Handlers.CommandHandler
{
    // User create command handler with UserResponse as output
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, UserResponse>
    {
        private readonly IUserCommandRepository _UserCommandRepository;
        public CreateUserHandler(IUserCommandRepository UserCommandRepository)
        {
            _UserCommandRepository = UserCommandRepository;
        }
        public async Task<UserResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var UserEntity = UserMapper.Mapper.Map<user>(request);

            if(UserEntity is null)
            {
                throw new ApplicationException("There is a problem in mapper");
            }

            var newUser = await _UserCommandRepository.AddAsync(UserEntity);
            var UserResponse = UserMapper.Mapper.Map<UserResponse>(newUser);
            return UserResponse;
        }
    }
}
