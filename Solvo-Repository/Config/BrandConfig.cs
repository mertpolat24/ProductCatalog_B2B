using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Solvo_Core.Models;

namespace Solvo_Repository.Config
{
    public class BrandConfig : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired().HasColumnType("nvarchar(50)");
        }
    }
}
