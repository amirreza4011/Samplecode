using MediatR;
using Ordering.Core.Entities;
using System.Collections.Generic;

namespace Ordering.Application.Queries
{
    // User query with List<User> response
    public record GetAllUserQuery : IRequest<List<user>>
    {

    }
}
