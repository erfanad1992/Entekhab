using Entekhab.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entekhab.Infrastructure.EfPersistance.TestModelEntityConfigurations
{
    public class TestModelEntityConfiguration : IEntityTypeConfiguration<TestModel>
    {
        public void Configure(EntityTypeBuilder<TestModel> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Name);
            builder.ToTable(nameof(TestModel));
        }
    }
}
