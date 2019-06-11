﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpearAutomation.Models.TCPT;

namespace SpearAutomation.Models.TCPT.Migrations
{
    [DbContext(typeof(SPEARTCPTContext))]
    [Migration("20190611052544_AddedAdditionalFields")]
    partial class AddedAdditionalFields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SpearAutomation.Models.TCPT.Resource", b =>
                {
                    b.Property<int>("ResourceId");

                    b.Property<bool>("Available");

                    b.Property<int?>("CertificationLevel");

                    b.Property<int>("Location");

                    b.Property<int>("Type");

                    b.Property<int?>("VehicleType");

                    b.HasKey("ResourceId");

                    b.ToTable("Resource");
                });
#pragma warning restore 612, 618
        }
    }
}
