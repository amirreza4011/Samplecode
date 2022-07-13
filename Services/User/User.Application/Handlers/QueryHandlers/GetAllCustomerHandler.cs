using MediatR;
using Ordering.Application.Queries;
using Ordering.Core.Entities;
using Ordering.Core.Repositories.Query;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Ordering.Application.Handlers.QueryHandlers
{
    // Get all User query handler with List<User> response as output
    public class GetAllUserHandler : IRequestHandler<GetAllUserQuery, List<user>>
    {
        private readonly IUserQueryRepository _UserQueryRepository;

        public GetAllUserHandler(IUserQueryRepository UserQueryRepository)
        {
            _UserQueryRepository = UserQueryRepository;
        }
        public async Task<List<user>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            return (List<user>)await _UserQueryRepository.GetAllAsync();
        }
    }
}
