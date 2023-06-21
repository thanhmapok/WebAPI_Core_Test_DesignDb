using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPI_Core_Test_DesignDb.Models;

namespace WebAPI_Core_Test_DesignDb.Data.Configurations
{
    public class WardConfiguration : IEntityTypeConfiguration<Ward>
    {
        public void Configure(EntityTypeBuilder<Ward> builder)
        {
            builder.ToTable("Wards");
            builder.HasKey(b => b.idWard);
            builder.Property(b => b.NameWard).HasMaxLength(50).IsUnicode().IsRequired();
        }
    }
}
