﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Owlbear.Model;

namespace Owlbear.Migrations
{
    [DbContext(typeof(OwlbearContext))]
    partial class OwlbearContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("Owlbear.Model.Creator", b =>
                {
                    b.Property<int>("CreatorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("TwitchTwitterId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TwitterId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CreatorId");

                    b.HasIndex("TwitchTwitterId");

                    b.HasIndex("TwitterId");

                    b.ToTable("Creators");
                });

            modelBuilder.Entity("Owlbear.Model.Twitch", b =>
                {
                    b.Property<int>("TwitterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("Followers")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Handle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OfflineImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProfileImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<int>("RemoteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RemoteLogin")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Views")
                        .HasColumnType("INTEGER");

                    b.HasKey("TwitterId");

                    b.ToTable("Twitch");
                });

            modelBuilder.Entity("Owlbear.Model.Twitter", b =>
                {
                    b.Property<int>("TwitterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("Followers")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Handle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("RemoteId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TwitterId");

                    b.ToTable("Twitter");
                });

            modelBuilder.Entity("Owlbear.Model.Creator", b =>
                {
                    b.HasOne("Owlbear.Model.Twitch", "Twitch")
                        .WithMany()
                        .HasForeignKey("TwitchTwitterId");

                    b.HasOne("Owlbear.Model.Twitter", "Twitter")
                        .WithMany()
                        .HasForeignKey("TwitterId");

                    b.Navigation("Twitch");

                    b.Navigation("Twitter");
                });
#pragma warning restore 612, 618
        }
    }
}
