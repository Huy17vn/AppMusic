﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicApplication.Data;

namespace MusicApplication.Migrations
{
    [DbContext(typeof(MyDbcontex))]
    [Migration("20181120031946_DBInits")]
    partial class DBInits
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MusicApplication.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("MusicApplication.Models.Song", b =>
                {
                    b.Property<int>("SongID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<string>("NameSong");

                    b.Property<string>("Singer");

                    b.HasKey("SongID");

                    b.ToTable("Song");
                });

            modelBuilder.Entity("MusicApplication.Models.SongCategory", b =>
                {
                    b.Property<int>("SongID");

                    b.Property<int>("CategoryID");

                    b.HasKey("SongID", "CategoryID");

                    b.HasIndex("CategoryID");

                    b.ToTable("SongCategory");
                });

            modelBuilder.Entity("MusicApplication.Models.SongCategory", b =>
                {
                    b.HasOne("MusicApplication.Models.Category", "Category")
                        .WithMany("SongCategories")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MusicApplication.Models.Song", "Song")
                        .WithMany("SongCategories")
                        .HasForeignKey("SongID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
