using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    [Table("Category")] // Tabela no banco de dados
    public class Category
    {
        [Key] // Chave primária
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required] // Torna a informação obrigatória NOT NULL
        [MinLength(3)] // Tamanho minimo da string
        [MaxLength(80)] // Tamando máximo da string
        [Column("Name", TypeName = "NVARCHAR")] // Especifica o tipo de dados da coluna
        public string Name { get; set; }


        public string Slug { get; set; }
    }
}