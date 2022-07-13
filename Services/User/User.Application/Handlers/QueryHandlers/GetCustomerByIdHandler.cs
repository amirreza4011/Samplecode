using MediatR;
using Ordering.Application.Queries;
using Ordering.Core.Entities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Ordering.Application.Handlers.QueryHandlers
{
    // Get specific query handler with User response as output
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, user>
    {
        private readonly IMediator _mediator;

        public GetUserByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<user> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var Users = await _mediator.Send(new GetAllUserQuery());
            var selectedUser = Users.FirstOrDefault(x => x.Id == request.Id);
            return selectedUser;
        }
    }
}
