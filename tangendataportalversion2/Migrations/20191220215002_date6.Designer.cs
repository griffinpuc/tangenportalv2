﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tangenportalv2.Models;

namespace tangendataportalversion2.Migrations
{
    [DbContext(typeof(databaseContext))]
    [Migration("20191220215002_date6")]
    partial class date6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("tangenportalv2.Models.BatchModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("batchName");

                    b.Property<int>("batchSize");

                    b.Property<string>("batchURL");

                    b.HasKey("ID");

                    b.ToTable("BatchTable");
                });

            modelBuilder.Entity("tangenportalv2.Models.InstrumentMod", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("dateAdded");

                    b.Property<bool>("isActive");

                    b.Property<string>("lastPing");

                    b.Property<string>("localAddress");

                    b.Property<string>("name");

                    b.Property<string>("status");

                    b.HasKey("ID");

                    b.ToTable("InstrumentTable");
                });

            modelBuilder.Entity("tangenportalv2.Models.ResultMod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("RunModId");

                    b.Property<string>("name");

                    b.Property<string>("outcomeCode");

                    b.Property<string>("outcomeString");

                    b.HasKey("Id");

                    b.HasIndex("RunModId");

                    b.ToTable("ResultMod");
                });

            modelBuilder.Entity("tangenportalv2.Models.RunMod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DirPointer");

                    b.Property<string>("assayId");

                    b.Property<string>("assayName");

                    b.Property<string>("dateTime");

                    b.Property<string>("instrumentName");

                    b.Property<string>("instrumentUuid");

                    b.Property<string>("kitLotId");

                    b.Property<string>("sampleId");

                    b.Property<string>("uniqueId");

                    b.HasKey("Id");

                    b.ToTable("RunTable");
                });

            modelBuilder.Entity("tangenportalv2.Models.TargetMod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("RunModId");

                    b.Property<string>("name");

                    b.Property<string>("outcomeCode");

                    b.Property<string>("outcomeString");

                    b.Property<string>("targetId");

                    b.HasKey("Id");

                    b.HasIndex("RunModId");

                    b.ToTable("TargetMod");
                });

            modelBuilder.Entity("tangenportalv2.Models.WellMod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("RunModId");

                    b.Property<string>("cq");

                    b.Property<string>("species");

                    b.Property<string>("wellId");

                    b.HasKey("Id");

                    b.HasIndex("RunModId");

                    b.ToTable("WellMod");
                });

            modelBuilder.Entity("tangenportalv2.Models.ResultMod", b =>
                {
                    b.HasOne("tangenportalv2.Models.RunMod")
                        .WithMany("results")
                        .HasForeignKey("RunModId");
                });

            modelBuilder.Entity("tangenportalv2.Models.TargetMod", b =>
                {
                    b.HasOne("tangenportalv2.Models.RunMod")
                        .WithMany("targets")
                        .HasForeignKey("RunModId");
                });

            modelBuilder.Entity("tangenportalv2.Models.WellMod", b =>
                {
                    b.HasOne("tangenportalv2.Models.RunMod")
                        .WithMany("wells")
                        .HasForeignKey("RunModId");
                });
#pragma warning restore 612, 618
        }
    }
}
