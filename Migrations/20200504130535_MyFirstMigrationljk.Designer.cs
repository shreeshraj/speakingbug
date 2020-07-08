﻿// <auto-generated />
using System;
using CoreProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreProject.Migrations
{
    [DbContext(typeof(LearningDbContext))]
    [Migration("20200504130535_MyFirstMigrationljk")]
    partial class MyFirstMigrationljk
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CoreProject.Models.Book", b =>
                {
                    b.Property<string>("ISBN")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Author")
                        .HasColumnType("text");

                    b.Property<string>("Language")
                        .HasColumnType("text");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<int?>("PublisherID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("ISBN");

                    b.HasIndex("PublisherID");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("CoreProject.Models.Publisher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("ID");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("CoreProject.Models.Book", b =>
                {
                    b.HasOne("CoreProject.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherID");
                });
#pragma warning restore 612, 618
        }
    }
}
