using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IDataAccess
    {
        Task<List<T>> LoadData<T, U>(string sql, U props);
        Task InsertData<T>(string sql, T parameters);
    }
}