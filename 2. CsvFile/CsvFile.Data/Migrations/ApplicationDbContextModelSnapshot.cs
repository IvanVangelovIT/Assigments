﻿// <auto-generated />
using CsvFile.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CsvFile.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CsvFile.Data.Models.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CancelledContractsForMonth")
                        .HasColumnType("int");

                    b.Property<int>("monthlyFee")
                        .HasColumnType("int");

                    b.Property<int>("newContractsForMonth")
                        .HasColumnType("int");

                    b.Property<int>("offerId")
                        .HasColumnType("int");

                    b.Property<int>("sameContractsForMonth")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("offer");
                });
#pragma warning restore 612, 618
        }
    }
}
