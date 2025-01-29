﻿// <auto-generated />
using FirstAspApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirstAspApp.Migrations
{
    [DbContext(typeof(VideoGameDbContext))]
    [Migration("20250129185639_Seeding")]
    partial class Seeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FirstAspApp.VideoGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Developer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Platform")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VideoGames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Developer = "Nintendo",
                            Platform = "Nintendo Switch",
                            Publisher = "Nintendo",
                            Title = "The Legend of Zelda: Breath of the Wild"
                        },
                        new
                        {
                            Id = 2,
                            Developer = "Santa Monica Studio",
                            Platform = "PlayStation 4",
                            Publisher = "Sony Interactive Entertainment",
                            Title = "God of War"
                        },
                        new
                        {
                            Id = 3,
                            Developer = "CD Projekt Red",
                            Platform = "PC, PlayStation, Xbox",
                            Publisher = "CD Projekt",
                            Title = "Cyberpunk 2077"
                        },
                        new
                        {
                            Id = 4,
                            Developer = "343 Industries",
                            Platform = "Xbox, PC",
                            Publisher = "Xbox Game Studios",
                            Title = "Halo Infinite"
                        },
                        new
                        {
                            Id = 5,
                            Developer = "Rockstar Games",
                            Platform = "PlayStation, Xbox, PC",
                            Publisher = "Rockstar Games",
                            Title = "Red Dead Redemption 2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
