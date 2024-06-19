using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    [Table("Post")] // Tabela no banco de dados
    public class Post
    {
        [Key] // Chave primária
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("CategoryId")] // Chave estrangeira
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey("AuthorId")] // Chave estrangeira
        public int AuthorId { get; set; }
        public User Author { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}