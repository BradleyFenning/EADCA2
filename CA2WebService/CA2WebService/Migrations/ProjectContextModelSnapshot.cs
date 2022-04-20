﻿// <auto-generated />
using CA2WebService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CA2WebService.Migrations
{
    [DbContext(typeof(ProjectContext))]
    partial class ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.16");

            modelBuilder.Entity("CA2WebService.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<bool>("AvailableForLoan")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BookName")
                        .HasColumnType("TEXT");

                    b.Property<int>("LibraryID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("CA2WebService.Library", b =>
                {
                    b.Property<int>("LibraryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("LibraryName")
                        .HasColumnType("TEXT");

                    b.HasKey("LibraryID");

                    b.ToTable("Libraries");
                });
#pragma warning restore 612, 618
        }
    }
}
