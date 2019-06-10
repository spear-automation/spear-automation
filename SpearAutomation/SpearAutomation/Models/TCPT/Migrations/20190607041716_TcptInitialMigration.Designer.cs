﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpearAutomation.Models.TCPT;

namespace SpearAutomation.Models.TCPT.Migrations
{
    [DbContext(typeof(SPEARTCPTContext))]
    [Migration("20190607041716_TcptInitialMigration")]
    partial class TcptInitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("SpearAutomation.Models.TCPT.Resource", b =>
                {
                    b.Property<int>("ResourceId");

                    b.Property<bool>("Available");

                    b.Property<int>("Location");

                    b.Property<int>("Type");

                    b.HasKey("ResourceId");

                    b.ToTable("Resource");
                });
#pragma warning restore 612, 618
        }
    }
}