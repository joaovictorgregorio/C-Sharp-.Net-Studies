using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog_project.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace blog_project.Repositories
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(SqlConnection connection)
            : base(connection)
            => Database.Connection = connection;

        public List<User> GetWithRoles()
        {
            var query = @"
                SELECT 
                    [User].*,
                    [Role].*
                FROM
                    [User]
                LEFT JOIN
                    [UserRole] ON [UserRole].[UserId] = [User].[Id]
                LEFT JOIN
                    [Role] ON [UserRole].[RoleId] = [Role].[Id]";

            var users = new List<User>();
            var item = Database.Connection.Query<User, Role, User>(
            query,
            (user, role) =>
            {
                var usr = users.FirstOrDefault(x => x.Id == user.Id);
                if (usr == null)
                {
                    usr = user;
                    if (role != null)
                        usr.Roles.Add(role);
                    users.Add(usr);
                }
                else
                    usr.Roles.Add(role);

                return user;
            }, splitOn: "Id");

            return users;
        }

        public static void AssociateUserRoles(int userId, List<int> roleIds)
        {
            // Delete existing UserRole records for the given userId
            var deleteQuery = @"DELETE FROM 
                                    [UserRole] 
                                WHERE 
                                    [UserId] = @UserId";

            Database.Connection.Execute(
                deleteQuery,
                new
                {
                    UserId = userId
                });

            // Create new UserRole records for each roleId associated with the userId
            var insertQuery = @"INSERT INTO 
                                    [UserRole] (UserId, RoleId) 
                                VALUES (@UserId, @RoleId)";

            foreach (var roleId in roleIds)
                Database.Connection.Execute(
                    insertQuery,
                    new
                    {
                        UserId = userId,
                        RoleId = roleId
                    });

        }

        internal void AssociateUserRoleScreen(int userId, List<int> selectedRoleIds)
        {
            throw new NotImplementedException();
        }
    }
}
