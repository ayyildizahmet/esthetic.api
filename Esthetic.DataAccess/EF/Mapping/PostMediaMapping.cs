using Esthetic.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Esthetic.DataAccess.EF.Mapping
{
    public class PostMediaMapping : IEntityTypeConfiguration<PostMedia>
    {
        public void Configure(EntityTypeBuilder<PostMedia> builder)
        {
            builder.ToTable("PostMedia");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Content).HasMaxLength(250);
            builder.Property(c => c.Day).IsRequired();
            builder.Property(c => c.PostId).IsRequired();
        }
    }
}
