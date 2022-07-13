using MediatR;
using Ordering.Application.Commands;
using Ordering.Application.Mapper;
using Ordering.Application.Response;
using Ordering.Core.Entities;
using Ordering.Core.Repositories.Command;
using Ordering.Core.Repositories.Query;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ordering.Application.Handlers.CommandHandler
{
    // User edit command handler with User response as output
    public class EditUserHandler : IRequestHandler<EditUserCommand, UserResponse>
    {
        private readonly IUserCommandRepository _UserCommandRepository;
        private readonly IUserQueryRepository _UserQueryRepository;
        public EditUserHandler(IUserCommandRepository UserRepository, IUserQueryRepository UserQueryRepository)
        {
            _UserCommandRepository = UserRepository;
            _UserQueryRepository = UserQueryRepository;
        }
        public async Task<UserResponse> Handle(EditUserCommand request, CancellationToken cancellationToken)
        {
            var UserEntity = UserMapper.Mapper.Map<user>(request);

            if (UserEntity is null)
            {
                throw new ApplicationException("There is a problem in mapper");
            }

            try
            {
                await _UserCommandRepository.UpdateAsync(UserEntity);
            }
            catch (Exception exp)
            {
                throw new ApplicationException(exp.Message);
            }

            var modifiedUser = await _UserQueryRepository.GetByIdAsync(request.Id);
            var UserResponse = UserMapper.Mapper.Map<UserResponse>(modifiedUser);

            return UserResponse;
        }
    }
}
