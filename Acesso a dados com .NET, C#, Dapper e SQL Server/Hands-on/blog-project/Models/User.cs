using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using TableAttribute = Dapper.Contrib.Extensions.TableAttribute;

namespace blog_project.Models
{
    // Notação importante para o Dapper contrib, buscando a table correta no banco de dados, por padrão ele buscará no formato em plural.
    [Table("[User]")]
    public class User
    {
        public User()
            => Roles = new List<Role>();
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }
        [Write(false)]
        public List<Role> Roles { get; set; }
    }
}