using Microsoft.EntityFrameworkCore;
using MovieRatings.Models;

namespace MovieRatings
{
    public class AppDbContext : DbContext
    {
        public DbSet<Movies> Movies { get; set; }
        public DbSet<MovieRating> MovieRatings { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
            
        }
    }
}
