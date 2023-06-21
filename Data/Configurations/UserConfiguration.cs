
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAPI_Core_Test_DesignDb.Models;

namespace WebAPI_Core_Test_DesignDb.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(b => b.idUser);
            builder.Property(b => b.Name).HasMaxLength(50).IsUnicode().IsRequired();
            builder.Property(b => b.Role);
            builder.Property(b => b.idWard);
        }

    }
}
