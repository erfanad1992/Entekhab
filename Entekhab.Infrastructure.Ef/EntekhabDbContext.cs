﻿using Entekhab.Domain;
using Entekhab.Infrastructure.EfPersistance.PersonInfos;
using Entekhab.Infrastructure.EfPersistance.TestModelEntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace Entekhab.Infrastructure.EfPersistance
{
    public class EntekhabDbContext : DbContext
    {
        public EntekhabDbContext(DbContextOptions<EntekhabDbContext> options) : base(options)
        {
        }

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
