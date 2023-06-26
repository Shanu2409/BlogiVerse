using BlogiVerseAPI.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace BlogiVerseAPI.Data
{
    public class BlogiVerseDbContext : DbContext
    {
        public BlogiVerseDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Difficulty> Difficulties { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }

        /*public DbSet<Image> Images { get; set; }*/
    }
}
