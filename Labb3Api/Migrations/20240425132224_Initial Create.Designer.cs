﻿// <auto-generated />
using Labb3Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb3Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240425132224_Initial Create")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Labb3Api.Models.Interests", b =>
                {
                    b.Property<int>("InterestsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InterestsID"), 1L, 1);

                    b.Property<string>("InterestsDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InterestsName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InterestsID");

                    b.ToTable("Interests");

                    b.HasData(
                        new
                        {
                            InterestsID = 1,
                            InterestsDescription = "C# is a programing language that are used in coding.",
                            InterestsName = "C#"
                        },
                        new
                        {
                            InterestsID = 2,
                            InterestsDescription = "Reading different kinds of books",
                            InterestsName = "Read"
                        },
                        new
                        {
                            InterestsID = 3,
                            InterestsDescription = "Kick a ball around and try to score",
                            InterestsName = "Football"
                        },
                        new
                        {
                            InterestsID = 4,
                            InterestsDescription = "Wooden board with wheels",
                            InterestsName = "Skateboarding"
                        },
                        new
                        {
                            InterestsID = 5,
                            InterestsDescription = "Coffee is made out of roasted beans, fun to make and drink",
                            InterestsName = "Coffee"
                        });
                });

            modelBuilder.Entity("Labb3Api.Models.Links", b =>
                {
                    b.Property<int>("LinkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LinkID"), 1L, 1);

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LinkID");

                    b.ToTable("Links");

                    b.HasData(
                        new
                        {
                            LinkID = 1,
                            Link = "https://en.wikipedia.org/wiki/C_Sharp_(programming_language)"
                        },
                        new
                        {
                            LinkID = 2,
                            Link = "https://www.amazon.com/books-used-books-textbooks/b?ie=UTF8&node=283155"
                        },
                        new
                        {
                            LinkID = 3,
                            Link = "https://sv.wikipedia.org/wiki/Football"
                        },
                        new
                        {
                            LinkID = 4,
                            Link = "https://en.wikipedia.org/wiki/Skateboarding"
                        },
                        new
                        {
                            LinkID = 5,
                            Link = "https://en.wikipedia.org/wiki/Coffee"
                        },
                        new
                        {
                            LinkID = 6,
                            Link = "https://www.britannica.com/topic/coffee"
                        });
                });

            modelBuilder.Entity("Labb3Api.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            FirstName = "Anas",
                            LastName = "Qlok",
                            Phone = "023329248"
                        },
                        new
                        {
                            UserID = 2,
                            FirstName = "Maureen",
                            LastName = "Larsson",
                            Phone = "072362462"
                        },
                        new
                        {
                            UserID = 3,
                            FirstName = "Sara",
                            LastName = "Sarasson",
                            Phone = "2099425498"
                        });
                });

            modelBuilder.Entity("Labb3Api.Models.UserConnection", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("InterestsID")
                        .HasColumnType("int");

                    b.Property<int>("LinksID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("InterestsID");

                    b.HasIndex("LinksID");

                    b.HasIndex("UserID");

                    b.ToTable("UserConnection");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            InterestsID = 1,
                            LinksID = 1,
                            UserID = 1
                        },
                        new
                        {
                            ID = 2,
                            InterestsID = 2,
                            LinksID = 2,
                            UserID = 2
                        },
                        new
                        {
                            ID = 3,
                            InterestsID = 3,
                            LinksID = 3,
                            UserID = 3
                        },
                        new
                        {
                            ID = 4,
                            InterestsID = 3,
                            LinksID = 3,
                            UserID = 2
                        },
                        new
                        {
                            ID = 5,
                            InterestsID = 4,
                            LinksID = 4,
                            UserID = 3
                        },
                        new
                        {
                            ID = 6,
                            InterestsID = 5,
                            LinksID = 5,
                            UserID = 3
                        },
                        new
                        {
                            ID = 7,
                            InterestsID = 5,
                            LinksID = 6,
                            UserID = 3
                        });
                });

            modelBuilder.Entity("Labb3Api.Models.UserConnection", b =>
                {
                    b.HasOne("Labb3Api.Models.Interests", "Interests")
                        .WithMany()
                        .HasForeignKey("InterestsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb3Api.Models.Links", "Links")
                        .WithMany()
                        .HasForeignKey("LinksID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb3Api.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Interests");

                    b.Navigation("Links");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
