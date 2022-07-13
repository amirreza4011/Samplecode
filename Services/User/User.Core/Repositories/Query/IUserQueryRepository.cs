using Ordering.Core.Entities;
using Ordering.Core.Repositories.Query.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ordering.Core.Repositories.Query
{
    // Interface for UserQueryRepository
    public interface IUserQueryRepository : IQueryRepository<user>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<user>> GetAllAsync();
        Task<user> GetByIdAsync(Int64 id);
        Task<user> GetUserByEmail(string email);
    }
}
