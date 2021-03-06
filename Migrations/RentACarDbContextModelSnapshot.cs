// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentACarBackend;

namespace RentACarBackend.Migrations
{
    [DbContext(typeof(RentACarDbContext))]
    partial class RentACarDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13");

            modelBuilder.Entity("RentACarBackend.Models.Cars.Car", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("ColorId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("EngineId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LuggageSpace")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ModelId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NumberPlate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Seats")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("TechnicallyApproved")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("EngineId");

                    b.HasIndex("ModelId");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("RentACarBackend.Models.Cars.CarType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CarType");
                });

            modelBuilder.Entity("RentACarBackend.Models.Cars.Color", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Color");
                });

            modelBuilder.Entity("RentACarBackend.Models.Cars.Country", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("RentACarBackend.Models.Cars.Engine", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cyllinders")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Displacement")
                        .HasColumnType("INTEGER");

                    b.Property<long>("FuelId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Power")
                        .HasColumnType("INTEGER");

                    b.Property<long>("PowertrainId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Torque")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TransmissionId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("FuelId");

                    b.HasIndex("PowertrainId");

                    b.HasIndex("TransmissionId");

                    b.ToTable("Engine");
                });

            modelBuilder.Entity("RentACarBackend.Models.Cars.Fuel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Fuel");
                });

            modelBuilder.Entity("RentACarBackend.Models.Cars.Manufacturer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CountryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("RentACarBackend.Models.Cars.Model", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CarTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ManufacturerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CarTypeId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Model");
                });

            modelBuilder.Entity("RentACarBackend.Models.Cars.Powertrain", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Powertrain");
                });

            modelBuilder.Entity("RentACarBackend.Models.Cars.Transmission", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Transmission");
                });

            modelBuilder.Entity("RentACarBackend.Models.Client", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("License")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LicenseExpiryDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UCN")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("RentACarBackend.Models.Company", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("companies");
                });

            modelBuilder.Entity("RentACarBackend.Models.Rent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("CarId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ClientId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("CompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DropOffDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PickUpDate")
                        .HasColumnType("TEXT");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("ClientId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Rent");
                });

            modelBuilder.Entity("RentACarBackend.Models.Cars.Car", b =>
                {
                    b.HasOne("RentACarBackend.Models.Cars.Color", null)
                        .WithMany("Cars")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentACarBackend.Models.Cars.Engine", null)
                        .WithMany("Cars")
                        .HasForeignKey("EngineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentACarBackend.Models.Cars.Model", null)
                        .WithMany("Cars")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RentACarBackend.Models.Cars.Engine", b =>
                {
                    b.HasOne("RentACarBackend.Models.Cars.Fuel", null)
                        .WithMany("Engines")
                        .HasForeignKey("FuelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentACarBackend.Models.Cars.Powertrain", null)
                        .WithMany("Engines")
                        .HasForeignKey("PowertrainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentACarBackend.Models.Cars.Transmission", null)
                        .WithMany("Engines")
                        .HasForeignKey("TransmissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RentACarBackend.Models.Cars.Manufacturer", b =>
                {
                    b.HasOne("RentACarBackend.Models.Cars.Country", null)
                        .WithMany("Manufacturers")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RentACarBackend.Models.Cars.Model", b =>
                {
                    b.HasOne("RentACarBackend.Models.Cars.CarType", null)
                        .WithMany("CarModels")
                        .HasForeignKey("CarTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentACarBackend.Models.Cars.Manufacturer", null)
                        .WithMany("CarModels")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RentACarBackend.Models.Rent", b =>
                {
                    b.HasOne("RentACarBackend.Models.Cars.Car", null)
                        .WithMany("Rents")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentACarBackend.Models.Client", null)
                        .WithMany("Rents")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentACarBackend.Models.Company", null)
                        .WithMany("Rents")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
