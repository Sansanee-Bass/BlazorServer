
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.Models
{

    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> opt) : base(opt) { }

        public DbSet<BlogEntry> Entries { get; set; }

    }
}