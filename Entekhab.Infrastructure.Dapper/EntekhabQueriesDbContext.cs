using Entekhab.Domain;
using Microsoft.EntityFrameworkCore;

namespace Entekhab.Infrastructure.EfPersistance
{
    public class EntekhabQueriesDbContext : DbContext
    {
        public EntekhabQueriesDbContext(DbContextOptions<EntekhabQueriesDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Resid> Resids { get; set; }
        public virtual DbSet<Mojavez> Mojavezes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Resid>()
            //    .HasMany(x => x.Mojavezes)
            //    .WithMany(x => x.Resids).UsingEntity(j=>j.ToTable("ResidMojavez"));
            modelBuilder.Entity<Resid>()
               .Ignore(e => e.Mojavezes);
            modelBuilder.Entity<Mojavez>()
           .Ignore(e => e.Resids);
            modelBuilder.Entity<Resid>().ToTable("Resid");
            modelBuilder.Entity<Mojavez>().ToTable("Mojavez");



            base.OnModelCreating(modelBuilder);

        }
    }
}
