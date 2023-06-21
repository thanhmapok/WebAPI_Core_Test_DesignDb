﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI_Core_Test_DesignDb.Data;

namespace WebAPI_Core_Test_DesignDb.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UserWard", b =>
                {
                    b.Property<int>("UsersidUser")
                        .HasColumnType("int");

                    b.Property<int>("WardidWard")
                        .HasColumnType("int");

                    b.HasKey("UsersidUser", "WardidWard");

                    b.HasIndex("WardidWard");

                    b.ToTable("UserWard");
                });

            modelBuilder.Entity("WebAPI_Core_Test_DesignDb.Models.User", b =>
                {
                    b.Property<int>("idUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idWard")
                        .HasColumnType("int");

                    b.HasKey("idUser");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebAPI_Core_Test_DesignDb.Models.Ward", b =>
                {
                    b.Property<int>("idWard")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameWard")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("idWard");

                    b.ToTable("Wards");
                });

            modelBuilder.Entity("UserWard", b =>
                {
                    b.HasOne("WebAPI_Core_Test_DesignDb.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersidUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI_Core_Test_DesignDb.Models.Ward", null)
                        .WithMany()
                        .HasForeignKey("WardidWard")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
