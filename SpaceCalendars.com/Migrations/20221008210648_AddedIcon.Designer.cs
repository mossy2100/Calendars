﻿// <auto-generated />
using System;
using Galaxon.Calendars.SpaceCalendars.com.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Galaxon.Calendars.SpaceCalendars.com.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221008210648_AddedIcon")]
    partial class AddedIcon
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Galaxon.Calendars.SpaceCalendars.com.Models.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FolderId")
                        .HasColumnType("int");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFolder")
                        .HasColumnType("bit");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("FolderId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("Galaxon.Calendars.SpaceCalendars.com.Models.Document", b =>
                {
                    b.HasOne("Galaxon.Calendars.SpaceCalendars.com.Models.Document", "Folder")
                        .WithMany("Documents")
                        .HasForeignKey("FolderId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Folder");
                });

            modelBuilder.Entity("Galaxon.Calendars.SpaceCalendars.com.Models.Document", b =>
                {
                    b.Navigation("Documents");
                });
#pragma warning restore 612, 618
        }
    }
}
