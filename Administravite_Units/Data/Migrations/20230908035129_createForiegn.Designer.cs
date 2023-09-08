﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230908035129_createForiegn")]
    partial class createForiegn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Data.Entity.Districs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Districs_Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int?>("Provinces_ID")
                        .HasColumnType("integer");

                    b.HasKey("ID");

                    b.HasIndex("Provinces_ID");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("Data.Entity.Provinces", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Provinces_Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("ID");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("Data.Entity.Wards", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<int?>("Districs_ID")
                        .HasColumnType("integer");

                    b.Property<string>("Wards_Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("ID");

                    b.HasIndex("Districs_ID");

                    b.ToTable("Wards");
                });

            modelBuilder.Entity("Data.Entity.Districs", b =>
                {
                    b.HasOne("Data.Entity.Provinces", "Provinces")
                        .WithMany("Districs")
                        .HasForeignKey("Provinces_ID");

                    b.Navigation("Provinces");
                });

            modelBuilder.Entity("Data.Entity.Wards", b =>
                {
                    b.HasOne("Data.Entity.Districs", "Districs")
                        .WithMany("Wards")
                        .HasForeignKey("Districs_ID");

                    b.Navigation("Districs");
                });

            modelBuilder.Entity("Data.Entity.Districs", b =>
                {
                    b.Navigation("Wards");
                });

            modelBuilder.Entity("Data.Entity.Provinces", b =>
                {
                    b.Navigation("Districs");
                });
#pragma warning restore 612, 618
        }
    }
}
