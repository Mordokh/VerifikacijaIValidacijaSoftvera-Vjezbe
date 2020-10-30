﻿// <auto-generated />
using System;
using BloodAlliance.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BloodAlliance.Migrations
{
    [DbContext(typeof(BAContext))]
    partial class BAContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BloodAlliance.Models.Bolnica", b =>
                {
                    b.Property<int>("BolnicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BolnicaId");

                    b.ToTable("Bolnica");
                });

            modelBuilder.Entity("BloodAlliance.Models.Donacija", b =>
                {
                    b.Property<int>("DonacijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumDonacije")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DonorId")
                        .HasColumnType("int");

                    b.Property<string>("ImeDoktora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KrvnaGrupa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ObavijestBolnicaId")
                        .HasColumnType("int");

                    b.Property<string>("RhFaktor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SifraDonacije")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DonacijaId");

                    b.HasIndex("DonorId");

                    b.HasIndex("ObavijestBolnicaId");

                    b.ToTable("Donacija");
                });

            modelBuilder.Entity("BloodAlliance.Models.Donor", b =>
                {
                    b.Property<int>("DonorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojDarivanja")
                        .HasColumnType("int");

                    b.Property<string>("BrojTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumPosljednjeDonacije")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hemoglobin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Jmbg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KrvnaGrupa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KrvniPritisak")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MjestoDarivanja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pol")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RhFaktor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusDonora")
                        .HasColumnType("int");

                    b.Property<double>("TjelesnaTezina")
                        .HasColumnType("float");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DonorId");

                    b.ToTable("Donor");
                });

            modelBuilder.Entity("BloodAlliance.Models.ObavijestBolnica", b =>
                {
                    b.Property<int>("ObavijestBolnicaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BolnicaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<string>("KrvnaGrupa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Obavijest")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ObavijestBolnicaId");

                    b.HasIndex("BolnicaId");

                    b.ToTable("ObavijestBolnica");
                });

            modelBuilder.Entity("BloodAlliance.Models.ObavijestDonor", b =>
                {
                    b.Property<int>("ObavijestDonorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumObavijesti")
                        .HasColumnType("datetime2");

                    b.Property<int>("DonorId")
                        .HasColumnType("int");

                    b.Property<string>("Obavijest")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ObavijestDonorId");

                    b.HasIndex("DonorId");

                    b.ToTable("ObavijestDonor");
                });

            modelBuilder.Entity("BloodAlliance.Models.Zahtjev", b =>
                {
                    b.Property<int>("ZahtjevId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BolnicaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<string>("KrvnaGrupa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NazivBolnice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RhFaktor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ZahtjevId");

                    b.HasIndex("BolnicaId");

                    b.ToTable("Zahtjev");
                });

            modelBuilder.Entity("BloodAlliance.Models.Donacija", b =>
                {
                    b.HasOne("BloodAlliance.Models.Donor", "Donor")
                        .WithMany("Donacije")
                        .HasForeignKey("DonorId");

                    b.HasOne("BloodAlliance.Models.ObavijestBolnica", null)
                        .WithMany("Donacije")
                        .HasForeignKey("ObavijestBolnicaId");
                });

            modelBuilder.Entity("BloodAlliance.Models.ObavijestBolnica", b =>
                {
                    b.HasOne("BloodAlliance.Models.Bolnica", "Bolnica")
                        .WithMany("Obavijesti")
                        .HasForeignKey("BolnicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BloodAlliance.Models.ObavijestDonor", b =>
                {
                    b.HasOne("BloodAlliance.Models.Donor", "Donor")
                        .WithMany("Obavijesti")
                        .HasForeignKey("DonorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BloodAlliance.Models.Zahtjev", b =>
                {
                    b.HasOne("BloodAlliance.Models.Bolnica", "Bolnica")
                        .WithMany("Zahtjevi")
                        .HasForeignKey("BolnicaId");
                });
#pragma warning restore 612, 618
        }
    }
}
