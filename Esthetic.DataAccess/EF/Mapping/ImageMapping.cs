using Esthetic.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Esthetic.DataAccess.EF.Mapping
{
    public class ImageMapping : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.ToTable("Image");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(200); //.IsRequired();
            builder.Property(c => c.Extension).HasMaxLength(10);  //.IsRequired();
            builder.Property(c => c.Data).IsRequired().HasColumnType("LongBlob");
            builder.Property(c => c.Size).IsRequired();
            builder.Property(c => c.ImageType).IsRequired();
            builder.Property(c => c.ImageCategoryType);

        }
    }
}
