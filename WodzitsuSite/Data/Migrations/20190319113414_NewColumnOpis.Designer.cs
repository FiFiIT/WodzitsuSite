﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WodzitsuSite.Data;

namespace WodzitsuSite.Migrations
{
    [DbContext(typeof(TourContext))]
    [Migration("20190319113414_NewColumnOpis")]
    partial class NewColumnOpis
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WodzitsuSite.Data.Entities.Tour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Hotel");

                    b.Property<decimal>("HotelCena");

                    b.Property<string>("Name");

                    b.Property<string>("Opis");

                    b.Property<string>("Organizator");

                    b.Property<decimal>("SamolotCena");

                    b.Property<string>("SamolotFirma");

                    b.Property<DateTime>("TerminDo");

                    b.Property<DateTime>("TerminOd");

                    b.Property<string>("Zdjecie");

                    b.HasKey("Id");

                    b.ToTable("Tours");
                });
#pragma warning restore 612, 618
        }
    }
}