using MediatR;
using Ordering.Core.Entities;
using System;

namespace Ordering.Application.Queries
{
    // User GetUserByIdQuery with User response
    public class GetUserByIdQuery: IRequest<user>
    {
        public Int64 Id { get; private set; }
        
        public GetUserByIdQuery(Int64 Id)
        {
            this.Id = Id;
        }

    }
}
