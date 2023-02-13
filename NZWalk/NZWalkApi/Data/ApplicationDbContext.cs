using Microsoft.EntityFrameworkCore;
using NZWalkApi.Models.Domain;

namespace NZWalkApi.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {

        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }

        public DbSet<WalkDifficulty> WalkDifficulties { get; set; }
    }
}
