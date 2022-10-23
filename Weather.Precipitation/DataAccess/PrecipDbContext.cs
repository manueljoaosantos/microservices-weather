using Microsoft.EntityFrameworkCore;

namespace Weather.Precipitation.DataAccess
{
    public class PrecipDbContext : DbContext
    {
        //public PrecipDbContext(){ }
        public PrecipDbContext(DbContextOptions<PrecipDbContext> opts) : base(opts) { }
        public DbSet<Precipitation> Precipitation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);
            SnakeCaseIdentityTablesNames(modelBuilder);
        }

        private static void SnakeCaseIdentityTablesNames(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Precipitation>(b => { b.ToTable("precipitation"); });
        }
    }
}
