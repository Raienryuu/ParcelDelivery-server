﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using bAPI;

namespace bAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220502082340_SafeToDel")]
    partial class SafeToDel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            modelBuilder.Entity("bAPI.Models.BidModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("BidValue")
                        .HasColumnType("REAL");

                    b.Property<int>("BidderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PackageId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BidderId");

                    b.HasIndex("PackageId");

                    b.ToTable("Bids");
                });

            modelBuilder.Entity("bAPI.Models.PackageModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("ApproximateDistance")
                        .HasColumnType("REAL");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Dimensions")
                        .HasColumnType("TEXT");

                    b.Property<string>("EndCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("EndPostCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("EndStreetAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("EndVoivodeship")
                        .HasColumnType("TEXT");

                    b.Property<float>("LowestBid")
                        .HasColumnType("REAL");

                    b.Property<int>("LowestBidId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OfferState")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("SenderHelp")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SenderId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StartCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("StartPostCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("StartStreetAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("StartVoivodeship")
                        .HasColumnType("TEXT");

                    b.Property<int>("TransporterId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("SenderId");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("bAPI.Models.RatingModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PackageId")
                        .HasColumnType("INTEGER");

                    b.Property<float>("RatedBySender")
                        .HasColumnType("REAL");

                    b.Property<float>("RatedByTransporter")
                        .HasColumnType("REAL");

                    b.Property<int>("SenderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TransporterId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PackageId");

                    b.HasIndex("SenderId");

                    b.HasIndex("TransporterId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("bAPI.Models.SessionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Token")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Token")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("UserSessions");
                });

            modelBuilder.Entity("bAPI.Models.UserDataModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContactInfo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Rating")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("Login")
                        .IsUnique();

                    b.HasIndex("Name", "Lastname");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ContactInfo = "berries11@gmail.com",
                            Lastname = "Berry",
                            Login = "user1",
                            Name = "Tom",
                            Password = "OYQ+xy+ILeo9tXmeT+/vNhDxnlNAl5KWXp25yeIE70/dWqjfSyRo/Xrtkoi8HEOm9WrTDXYhdxONT5CLOmJLcg==",
                            Rating = 0f
                        },
                        new
                        {
                            Id = 2,
                            ContactInfo = "mousepaul@yahoo.com",
                            Lastname = "Jerry",
                            Login = "user2",
                            Name = "Paul",
                            Password = "R7WDCLmMmLg71VR+F1S4CNCc2OCOhuxxs5RHcxOO5gtInrMrVTwyI68SGNk1eZleRQckSe7oKsSgyNi26XQ0VA==",
                            Rating = 0f
                        });
                });

            modelBuilder.Entity("bAPI.Models.BidModel", b =>
                {
                    b.HasOne("bAPI.Models.UserDataModel", "Bidder")
                        .WithMany()
                        .HasForeignKey("BidderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bAPI.Models.PackageModel", "Package")
                        .WithMany()
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bidder");

                    b.Navigation("Package");
                });

            modelBuilder.Entity("bAPI.Models.PackageModel", b =>
                {
                    b.HasOne("bAPI.Models.UserDataModel", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("bAPI.Models.RatingModel", b =>
                {
                    b.HasOne("bAPI.Models.PackageModel", "Package")
                        .WithMany()
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bAPI.Models.UserDataModel", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bAPI.Models.UserDataModel", "Transporter")
                        .WithMany()
                        .HasForeignKey("TransporterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Package");

                    b.Navigation("Sender");

                    b.Navigation("Transporter");
                });

            modelBuilder.Entity("bAPI.Models.SessionModel", b =>
                {
                    b.HasOne("bAPI.Models.UserDataModel", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
