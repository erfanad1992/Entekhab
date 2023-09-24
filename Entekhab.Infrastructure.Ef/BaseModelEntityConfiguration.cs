using Entekhab.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Entekhab.Infrastructure.EfPersistance
{
    public class BaseModelEntityConfiguration : IEntityTypeConfiguration<Base>
    {
        public void Configure(EntityTypeBuilder<Base> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(x => x.FieldName);
            builder.ToTable(nameof(Base),"dbo");
        }
    }
}
