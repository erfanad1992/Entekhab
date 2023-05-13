﻿using Entekhab.Infrastructure.EfPersistance.TestModelEntityConfigurations;
using Microsoft.EntityFrameworkCore;
namespace Entekhab.Infrastructure.EfPersistance
{
    public class EntekhabDbContext : DbContext
    {
        public EntekhabDbContext(DbContextOptions<EntekhabDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TestModelEntityConfiguration());

            base.OnModelCreating(modelBuilder);

        }
    }
}
