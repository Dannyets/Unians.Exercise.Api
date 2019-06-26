﻿// <auto-generated />
using System;
using Exercise.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Exercise.DAL.Migrations
{
    [DbContext(typeof(ExerciseDbContext))]
    partial class ExerciseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Exercise.DAL.Models.ExerciseDbModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<DateTime>("LastUdpatedAt");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Exercises");
                });
#pragma warning restore 612, 618
        }
    }
}
