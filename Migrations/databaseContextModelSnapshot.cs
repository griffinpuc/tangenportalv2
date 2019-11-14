﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tangenportalv2.Models;

namespace tangendataportalversion2.Migrations
{
    [DbContext(typeof(databaseContext))]
    partial class databaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("tangenportalv2.Models.InstrumentMod", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("lastPing");

                    b.Property<string>("localAddress");

                    b.Property<string>("name");

                    b.Property<string>("status");

                    b.HasKey("ID");

                    b.ToTable("InstrumentTable");
                });

            modelBuilder.Entity("tangenportalv2.RunMod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssayId");

                    b.Property<string>("DirPointer");

                    b.Property<string>("DownloadDateTime");

                    b.Property<string>("InstrumentName");

                    b.Property<string>("InstrumentUuid");

                    b.Property<string>("KitLotId");

                    b.Property<string>("SampleId");

                    b.Property<string>("UniqueId");

                    b.HasKey("Id");

                    b.ToTable("RunTable");
                });
#pragma warning restore 612, 618
        }
    }
}
