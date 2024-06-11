using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace blog_project.Repositories
{
    public class Repository<T> where T : class
    {
        private readonly SqlConnection _connection;

        public Repository(SqlConnection connection)
            => _connection = connection;

        public IEnumerable<T> Get()
            => _connection.GetAll<T>();
    }
}