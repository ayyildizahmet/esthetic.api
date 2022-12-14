using Esthetic.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Esthetic.DataAccess.EF.Mapping
{
    public class CompanyMapping : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Company");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(250).IsRequired();
            builder.Property(c => c.LogoUrl).HasMaxLength(250).IsRequired();
        }
    }
}
