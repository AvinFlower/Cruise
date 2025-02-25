﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Tickets_for_the_tour;

#nullable disable

namespace Tickets_for_the_tour.Migrations
{
    [DbContext(typeof(TourContext))]
    partial class TourContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AttractionRoutePoint", b =>
                {
                    b.Property<Guid>("AttractionsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoutePointsId")
                        .HasColumnType("uuid");

                    b.HasKey("AttractionsId", "RoutePointsId");

                    b.HasIndex("RoutePointsId");

                    b.ToTable("AttractionRoutePoint");
                });

            modelBuilder.Entity("Tickets_for_the_tour.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Tickets_for_the_tour.Attraction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AttractionAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AttractionName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Attractions");
                });

            modelBuilder.Entity("Tickets_for_the_tour.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PassportData")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Tickets_for_the_tour.Excursion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ExcursionVariants")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("PriceExcursion")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("Excursions");
                });

            modelBuilder.Entity("Tickets_for_the_tour.Flight", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DepartureDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DeparturePlace")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DestinationPlace")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("interval");

                    b.Property<Guid>("ExcursionId")
                        .HasColumnType("uuid");

                    b.Property<int>("NumberFlights")
                        .HasColumnType("integer");

                    b.Property<Guid>("ShipId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ExcursionId");

                    b.HasIndex("ShipId");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("Tickets_for_the_tour.Passenger", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Grachdanstvo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PassportData")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Passenger");
                });

            modelBuilder.Entity("Tickets_for_the_tour.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ID_Ticket")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("PaymentDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ID_Ticket")
                        .IsUnique();

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Tickets_for_the_tour.Route", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<double>("Distance")
                        .HasColumnType("double precision");

                    b.Property<Guid>("ID_Excursion")
                        .HasColumnType("uuid");

                    b.Property<string>("RouteName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ID_Excursion")
                        .IsUnique();

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("Tickets_for_the_tour.RoutePoint", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("RouteId")
                        .HasColumnType("uuid");

                    b.Property<TimeSpan>("StopDuration")
                        .HasColumnType("interval");

                    b.HasKey("Id");

                    b.HasIndex("RouteId");

                    b.ToTable("RoutePoints");
                });

            modelBuilder.Entity("Tickets_for_the_tour.Ship", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<string>("ComfortLevel")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShipName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Speed")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Ships");
                });

            modelBuilder.Entity("Tickets_for_the_tour.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("FlightId")
                        .HasColumnType("uuid");

                    b.Property<int>("NumberTicket")
                        .HasColumnType("integer");

                    b.Property<Guid>("PassengerId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("TicketPrice")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("FlightId");

                    b.HasIndex("PassengerId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("AttractionRoutePoint", b =>
                {
                    b.HasOne("Tickets_for_the_tour.Attraction", null)
                        .WithMany()
                        .HasForeignKey("AttractionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tickets_for_the_tour.RoutePoint", null)
                        .WithMany()
                        .HasForeignKey("RoutePointsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Tickets_for_the_tour.Flight", b =>
                {
                    b.HasOne("Tickets_for_the_tour.Excursion", "Excursion")
                        .WithMany("Flights")
                        .HasForeignKey("ExcursionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tickets_for_the_tour.Ship", "Ship")
                        .WithMany("Flights")
                        .HasForeignKey("ShipId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Excursion");

                    b.Navigation("Ship");
                });

            modelBuilder.Entity("Tickets_for_the_tour.Payment", b =>
                {
                    b.HasOne("Tickets_for_the_tour.Ticket", "Ticket")
                        .WithOne("Payment")
                        .HasForeignKey("Tickets_for_the_tour.Payment", "ID_Ticket")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("Tickets_for_the_tour.Route", b =>
                {
                    b.HasOne("Tickets_for_the_tour.Excursion", "Excursion")
                        .WithOne("Route")
                        .HasForeignKey("Tickets_for_the_tour.Route", "ID_Excursion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Excursion");
                });

            modelBuilder.Entity("Tickets_for_the_tour.RoutePoint", b =>
                {
                    b.HasOne("Tickets_for_the_tour.Route", "Route")
                        .WithMany("RoutePoints")
                        .HasForeignKey("RouteId");

                    b.Navigation("Route");
                });

            modelBuilder.Entity("Tickets_for_the_tour.Ticket", b =>
                {
                    b.HasOne("Tickets_for_the_tour.Flight", "Flight")
                        .WithMany("Tickets")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Tickets_for_the_tour.Passenger", "Passenger")
                        .WithMany("Tickets")
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");

                    b.Navigation("Passenger");
                });

            modelBuilder.Entity("Tickets_for_the_tour.Excursion", b =>
                {
                    b.Navigation("Flights");

                    b.Navigation("Route")
                        .IsRequired();
                });

            modelBuilder.Entity("Tickets_for_the_tour.Flight", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("Tickets_for_the_tour.Passenger", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("Tickets_for_the_tour.Route", b =>
                {
                    b.Navigation("RoutePoints");
                });

            modelBuilder.Entity("Tickets_for_the_tour.Ship", b =>
                {
                    b.Navigation("Flights");
                });

            modelBuilder.Entity("Tickets_for_the_tour.Ticket", b =>
                {
                    b.Navigation("Payment")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
