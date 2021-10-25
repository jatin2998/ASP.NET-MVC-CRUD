using Blog.Data;
using Microsoft.EntityFrameworkCore;

namespace Blog.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BlogContext(
                serviceProvider.GetRequiredService<DbContextOptions<BlogContext>>()))
            {
                // Look for any Blog Post
                if (context.Post.Any())
                {
                    return;
                }
                context.Post.AddRange(
                    new Post
                    {
                        Title = "Test Post",
                        Description = "This is just a Test Post Ignore it.",
                        Footer = "Happy Coding",
                        CreatedAt = DateTime.Now
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
