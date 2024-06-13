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
        public Repository(SqlConnection connection)
            => Database.Connection = connection;

        public IEnumerable<T> Get()
            => Database.Connection.GetAll<T>();

        public T Get(int id)
            => Database.Connection.Get<T>(id);

        public void Create(T model)
            => Database.Connection.Insert<T>(model);

        public void Update(T model)
            => Database.Connection.Update<T>(model);

        public void Delete(T model)
            => Database.Connection.Delete<T>(model);

        public void Delete(int id)
        {
            var model = Database.Connection.Get<T>(id);
            Database.Connection.Delete<T>(model);
        }
    }
}