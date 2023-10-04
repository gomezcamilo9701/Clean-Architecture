using Microsoft.EntityFrameworkCore;
using CleanArchitecture.Domain;

namespace CleanArchitecture.Data
{
    public class StreamerDbContext : DbContext
    {
        /** We should right click on dependecies and the "Add reference project"
         * then we will be able to use <Streamer> and <Video>
         * INSTALL EF SQL SERVER && EF TOOLS
        */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source=localhost\sqlserver; Inital Catalog=Streamer;Integrated Security=True");
        }
        public DbSet<Streamer>? Streamers { get; set; }
        public DbSet<Video>? Videos { get; set; }


    }
}