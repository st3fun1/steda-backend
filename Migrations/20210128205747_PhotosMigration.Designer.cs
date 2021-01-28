﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Steda_backend.Authentication;

namespace Steda_backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210128205747_PhotosMigration")]
    partial class PhotosMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Steda_backend.Models.Photo", b =>
                {
                    b.Property<int>("PhotoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PhotoID");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasColumnName("Name");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500) CHARACTER SET utf8mb4")
                        .HasColumnName("Url");

                    b.Property<bool>("isLiked")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("isLiked");

                    b.HasKey("PhotoID");

                    b.ToTable("Photos");
                });
#pragma warning restore 612, 618
        }
    }
}
