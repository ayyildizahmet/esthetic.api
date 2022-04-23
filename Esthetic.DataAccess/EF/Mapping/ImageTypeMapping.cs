using MakeEat.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MakeEat.DataAccess.EF.Mapping
{
    public class ImageTypeMapping : IEntityTypeConfiguration<ImageType>
    {
        public void Configure(EntityTypeBuilder<ImageType> builder)
        {
            builder.ToTable("ImageType");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(200).IsRequired();
        }
    }
}
