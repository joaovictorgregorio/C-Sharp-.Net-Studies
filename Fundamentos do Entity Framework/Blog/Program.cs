using Blog.Data;
using Blog.Models;
using Microsoft.Identity.Client;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var context = new BlogDataContext())
        {
            UpdateTag(context);
        }
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
        tag.Slug = ".net";

        context.Update(tag);
        context.SaveChanges();
    }
}