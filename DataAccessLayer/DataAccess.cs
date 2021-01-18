using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace DataAccessLayer
{
    public class DataAccess : IDataAccess
    {
        private readonly IConfiguration _config;
        public string ConnectionStringName { get; set; } = "Default";

        public DataAccess(IConfiguration config)
        {
            _config = config;
        }
        
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            var connectionString = _config.GetConnectionString(ConnectionStringName);
            
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                var data = await dbConnection.QueryAsync<T>(sql, parameters);

                return data.ToList();
            }
        }

        public async Task InsertData<T>(string sql, T parameters)
        {
            var connectionString = _config.GetConnectionString(ConnectionStringName);
            
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                await dbConnection.ExecuteAsync(sql, parameters);
            }
        }
    }
}