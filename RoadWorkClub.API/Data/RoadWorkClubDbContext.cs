using Microsoft.EntityFrameworkCore;
using RoadWorkClub.API.Models.Domain;

namespace RoadWorkClub.API.Data
{
    public class RoadWorkClubDbContext : DbContext
    {
        public RoadWorkClubDbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
            
        }

        // EF Core will build into tables when I run migration
       public DbSet<Pathway> Path { get; set; }
        public DbSet<Stopover> Stopovers { get; set; }

    }
}
