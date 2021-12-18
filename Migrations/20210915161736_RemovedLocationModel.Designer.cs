﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bAPI;

namespace bAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210915161736_RemovedLocationModel")]
    partial class RemovedLocationModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

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

                    b.ToTable("BidModel");
                });

            modelBuilder.Entity("bAPI.Models.PackageModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EndCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("EndPostCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("EndStreetAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("EndVoivodeship")
                        .HasColumnType("TEXT");

                    b.Property<int?>("LowestBidId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OfferState")
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

                    b.HasIndex("LowestBidId");

                    b.ToTable("PackageModel");
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

                    b.ToTable("UserSessions");
                });

            modelBuilder.Entity("bAPI.Models.UserDataModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Lastname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Lastname = "Berry",
                            Login = "user1",
                            Name = "Tom",
                            Password = "haslo1"
                        },
                        new
                        {
                            Id = 2,
                            Lastname = "Jerry",
                            Login = "user2",
                            Name = "Paul",
                            Password = "haslo2"
                        });
                });

            modelBuilder.Entity("bAPI.Models.PackageModel", b =>
                {
                    b.HasOne("bAPI.Models.BidModel", "LowestBid")
                        .WithMany()
                        .HasForeignKey("LowestBidId");

                    b.Navigation("LowestBid");
                });
#pragma warning restore 612, 618
        }
    }
}