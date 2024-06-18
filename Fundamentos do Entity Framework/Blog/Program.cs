using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        using (var context = new BlogDataContext())
        {
            ListTag(context);
        }

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