using Microsoft.EntityFrameworkCore;

namespace MovieCollection.Models
{
    public class MovieContext : DbContext
    {
        //Constructor
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            //Leave blank for now
        }

        public DbSet<MovieEntry> Responses { get; set; }
    }
}
