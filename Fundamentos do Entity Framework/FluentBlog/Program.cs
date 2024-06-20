using Blog.Data;
using Blog.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        using var context = new BlogDataContext();

        var user = context.Users.FirstOrDefault();
        var post = new Post
        {
            Author = null,
            Body = "Meu artigo",
            Category = new Category
            {
                Name = "Developer IOS",
                Slug = "developer-ios"
            },
            CreateDate = System.DateTime.Now,
            // LastUpdateDate = 
            Slug = "meu-artigo",
            Summary = "Neste artigo vamos conferir...",
            // Tags = null
            Title = "Meu artigo"
        };

        context.Posts.Add(post);
        context.SaveChanges();
    }

    public static void CreateUser()
    {
        using var context = new BlogDataContext();

        context.Users.Add(
            new User
            {
                Name = "John Doe",
                Email = "john.doe@example.com",
                PasswordHash = "123456",
                Image = "https://example.com/john-doe.jpg",
                Bio = "John Doe is a software developer",
                Slug = "john-doe"
            });
        context.SaveChanges();
    }

    public static void CreatePost()
    {

    }
}