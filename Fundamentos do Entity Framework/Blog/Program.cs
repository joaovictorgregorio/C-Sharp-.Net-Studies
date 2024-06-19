using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        /*
        var user = new User
        {
            Name = "Martins",
            Email = "XXXXXXXXXXXXXX",
            PasswordHash = "123456",
            Bio = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce a augue ac orci elementum lacinia.",
            Image = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
            Slug = "martins"
        };

        var category = new Category
        {
            Name = "Mobile",
            Slug = "mobile"
        };

        var post = new Post
        {
            Author = user,
            Category = category,
            Title = "Começando-com-ef-core",
            Summary = "Aprendendo a utilizar o EF Core",
            Slug = "comecando-com-ef-core",
            Body = "<p>Hello world</p>",
            CreateDate = DateTime.Now,
            LastUpdateDate = DateTime.Now
        };

        context.Posts.Add(post);
        context.SaveChanges();
        */
        using var context = new BlogDataContext();
        /*
        var posts = context
            .Posts
            .AsNoTracking()
            .Include(x => x.Author)
            .Include(x => x.Category)
            .OrderByDescending(x => x.LastUpdateDate)
            .ToList();

        foreach (var post in posts)
            Console.WriteLine(
                $"{post.Title} escrito por {post.Author?.Name} e, {post.Category?.Name}");
        */

        var post = context
            .Posts
            // .AsNoTracking()
            .Include(x => x.Author)
            .Include(x => x.Category)
            .OrderByDescending(x => x.LastUpdateDate)
            .FirstOrDefault();

        post.Author.Name = "Teste";

        context.Posts.Update(post);
        context.SaveChanges();

        Console.ReadKey();
    }

    public static void CreateTag(BlogDataContext context)
    {
        var tag = new Tag
        {
            Name = "Azure",
            Slug = "azure"
        };
        context.Tags.Add(tag);
        context.SaveChanges();
    }

    public static void UpdateTag(BlogDataContext context)
    {
        var tag = context.Tags.FirstOrDefault(x => x.Id == 5);
        tag.Name = "DOTNET";
        tag.Slug = ".NET";

        context.Update(tag);
        context.SaveChanges();
    }

    public static void DeleteTag(BlogDataContext context)
    {
        var tag = context.Tags.FirstOrDefault(x => x.Id == 3);
        context.Remove(tag);
        context.SaveChanges();
    }

    public static void ListTag(BlogDataContext context)
    {
        var tags = context
            .Tags
            .AsNoTracking()
            .ToList();

        foreach (var tag in tags)
            Console.WriteLine(tag.Name);
    }
}