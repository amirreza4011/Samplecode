using Dapper;
using Microsoft.Extensions.Configuration;
using Ordering.Core.Entities;
using Ordering.Core.Repositories.Query;
using Ordering.Infrastructure.Repository.Query.Base;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Repository.Query
{
    // QueryRepository class for User
    public class UserQueryRepository : QueryRepository<user>, IUserQueryRepository
    {
        public UserQueryRepository(IConfiguration configuration) 
            : base(configuration)
        {

        }

        public async Task<IReadOnlyList<user>> GetAllAsync()
        {
            try
            {
                var query = "SELECT * FROM UserS";

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<user>(query)).ToList();
                }
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<user> GetByIdAsync(long id)
        {
            try
            {
                var query = "SELECT * FROM UserS WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("Id", id, DbType.Int64);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<user>(query, parameters));
                }
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }

        public async Task<user> GetUserByEmail(string email)
        {
            try
            {
                var query = "SELECT * FROM UserS WHERE Email = @email";
                var parameters = new DynamicParameters();
                parameters.Add("Email", email, DbType.String);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<user>(query, parameters));
                }
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message, exp);
            }
        }
    }
}
