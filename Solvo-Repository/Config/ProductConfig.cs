using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Solvo_Core.Models;

namespace Solvo_Repository.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired().HasColumnType("nvarchar(50)");
        }
    }
}
