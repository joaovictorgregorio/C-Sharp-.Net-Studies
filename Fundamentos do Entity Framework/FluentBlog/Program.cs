using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    static async Task Main(string[] args)
    {
        using var context = new BlogDataContext();

        var postsOne = GetPosts(context, 0, 25);
        var postsTwo = GetPosts(context, 25, 50);


    }

    // static async Task<List<Post>> GetPosts(BlogDataContext context)
    //     => await context.Posts.ToListAsync();

    public static List<Post> GetPosts(
        BlogDataContext context, int skip = 0, int take = 25)
    {
        var posts = context.Posts
        .AsNoTracking()
        .Skip(skip)
        .Take(take)
        .ToList();

        return posts;
    }

}