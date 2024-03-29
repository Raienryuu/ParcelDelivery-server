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
    [Migration("20211218182056_FullDatabase")]
    partial class FullDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            modelBuilder.Entity("bAPI.Models.BidModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<float>("BidValue")
                        .HasColumnType("real");

                    b.Property<int>("FK_PackageId")
                        .HasColumnType("integer");

                    b.Property<int>("FK_UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("FK_PackageId");

                    b.HasIndex("FK_UserId");

                    b.ToTable("Bids");
                });

            modelBuilder.Entity("bAPI.Models.PackageModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EndCity")
                        .HasColumnType("text");

                    b.Property<string>("EndPostCode")
                        .HasColumnType("text");

                    b.Property<string>("EndStreetAddress")
                        .HasColumnType("text");

                    b.Property<string>("EndVoivodeship")
                        .HasColumnType("text");

                    b.Property<int?>("FK_Lowest_BidId")
                        .HasColumnType("integer");

                    b.Property<int>("FK_UserId1")
                        .HasColumnType("integer");

                    b.Property<int?>("FK_UserId2")
                        .HasColumnType("integer");

                    b.Property<int>("OfferState")
                        .HasColumnType("integer");

                    b.Property<string>("StartCity")
                        .HasColumnType("text");

                    b.Property<string>("StartPostCode")
                        .HasColumnType("text");

                    b.Property<string>("StartStreetAddress")
                        .HasColumnType("text");

                    b.Property<string>("StartVoivodeship")
                        .HasColumnType("text");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("FK_Lowest_BidId");

                    b.HasIndex("FK_UserId1");

                    b.HasIndex("FK_UserId2");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("bAPI.Models.RatingModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<int>("FK_PackageId")
                        .HasColumnType("integer");

                    b.Property<int>("FK_SenderId")
                        .HasColumnType("integer");

                    b.Property<int>("FK_TransporterId")
                        .HasColumnType("integer");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("FK_PackageId");

                    b.HasIndex("FK_SenderId");

                    b.HasIndex("FK_TransporterId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("bAPI.Models.SessionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<int>("FK_UserId")
                        .HasColumnType("integer");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FK_UserId");

                    b.HasIndex("Token")
                        .IsUnique();

                    b.ToTable("UserSessions");
                });

            modelBuilder.Entity("bAPI.Models.UserDataModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

                    b.Property<string>("ContactInfo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

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
                            Password = "haslo1",
                            Rating = 0f
                        },
                        new
                        {
                            Id = 2,
                            ContactInfo = "mousepaul@yahoo.com",
                            Lastname = "Jerry",
                            Login = "user2",
                            Name = "Paul",
                            Password = "haslo2",
                            Rating = 0f
                        });
                });

            modelBuilder.Entity("bAPI.Models.BidModel", b =>
                {
                    b.HasOne("bAPI.Models.PackageModel", "PackageId")
                        .WithMany()
                        .HasForeignKey("FK_PackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bAPI.Models.UserDataModel", "BidderId")
                        .WithMany()
                        .HasForeignKey("FK_UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BidderId");

                    b.Navigation("PackageId");
                });

            modelBuilder.Entity("bAPI.Models.PackageModel", b =>
                {
                    b.HasOne("bAPI.Models.BidModel", "LowestBid")
                        .WithMany()
                        .HasForeignKey("FK_Lowest_BidId");

                    b.HasOne("bAPI.Models.UserDataModel", "SenderId")
                        .WithMany()
                        .HasForeignKey("FK_UserId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bAPI.Models.UserDataModel", "TransporterId")
                        .WithMany()
                        .HasForeignKey("FK_UserId2");

                    b.Navigation("LowestBid");

                    b.Navigation("SenderId");

                    b.Navigation("TransporterId");
                });

            modelBuilder.Entity("bAPI.Models.RatingModel", b =>
                {
                    b.HasOne("bAPI.Models.PackageModel", "PackageId")
                        .WithMany()
                        .HasForeignKey("FK_PackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bAPI.Models.UserDataModel", "SenderId")
                        .WithMany()
                        .HasForeignKey("FK_SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("bAPI.Models.UserDataModel", "TransporterId")
                        .WithMany()
                        .HasForeignKey("FK_TransporterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PackageId");

                    b.Navigation("SenderId");

                    b.Navigation("TransporterId");
                });

            modelBuilder.Entity("bAPI.Models.SessionModel", b =>
                {
                    b.HasOne("bAPI.Models.UserDataModel", "UserId")
                        .WithMany()
                        .HasForeignKey("FK_UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
