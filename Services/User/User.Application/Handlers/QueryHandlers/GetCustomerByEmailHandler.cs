using MediatR;
using Ordering.Application.Queries;
using Ordering.Core.Entities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Ordering.Application.Handlers.QueryHandlers
{
    // Get specific User query handler with User response as output
    public class GetUserByEmailHandler : IRequestHandler<GetUserByEmailQuery, user>
    {
        private readonly IMediator _mediator;

        public GetUserByEmailHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<user> Handle(GetUserByEmailQuery request, CancellationToken cancellationToken)
        {
            var Users = await _mediator.Send(new GetAllUserQuery());
            var selectedUser = Users.FirstOrDefault(x => x.FirstName.ToLower().Contains(request.Email.ToLower()));
            return selectedUser;
        }
    }
}
