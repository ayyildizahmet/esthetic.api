using MakeEat.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MakeEat.DataAccess.EF.Mapping
{
    public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(100).IsRequired(true);
            builder.Property(c => c.Description).HasMaxLength(500).IsRequired(true);
            builder.Property(c => c.Latitude).HasMaxLength(10);
            builder.Property(c => c.Longitude).HasMaxLength(10);
        }
    }
}
