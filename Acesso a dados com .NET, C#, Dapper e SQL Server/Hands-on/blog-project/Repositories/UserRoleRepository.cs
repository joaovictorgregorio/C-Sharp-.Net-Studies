using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_project.Models;
using Microsoft.Data.SqlClient;

namespace blog_project.Repositories
{
    public class UserRoleRepository : Repository<UserRole>
    {
        public UserRoleRepository(SqlConnection connection)
            : base(connection)
            => Database.Connection = connection;

        
    }
}