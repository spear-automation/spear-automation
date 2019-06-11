﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpearAutomation.Models.Logger.Data;

namespace SpearAutomation.Models.Logger.Migrations
{
    [DbContext(typeof(LoggerContext))]
    partial class LoggerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("SpearAutomation.Models.Logger.Model.EventLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<DateTime?>("CreatedTime");

                    b.Property<int?>("EventId")
                        .HasColumnName("EventID");

                    b.Property<string>("LogLevel")
                        .HasMaxLength(50);

                    b.Property<string>("Message")
                        .HasMaxLength(4000);

                    b.HasKey("Id");

                    b.ToTable("EventLog");
                });
#pragma warning restore 612, 618
        }
    }
}