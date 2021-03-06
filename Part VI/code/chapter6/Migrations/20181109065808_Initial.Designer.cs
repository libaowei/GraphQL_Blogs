﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using chapter1;

namespace chapter1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181109065808_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("chapter1.Item", b =>
                {
                    b.Property<string>("Barcode")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("SellingPrice");

                    b.Property<string>("Title");

                    b.HasKey("Barcode");

                    b.ToTable("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
