﻿// <auto-generated />
using System;
using Coworking.Api.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Coworking.Api.DataAccess.Migrations
{
    [DbContext(typeof(CoworkingContext))]
    partial class CoworkingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.Admin", b =>
                {
                    b.Property<int>("IdAdmin")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("IdAdmin");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.Booking", b =>
                {
                    b.Property<int>("IdBooking")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BookinDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("date");

                    b.Property<int?>("OfficeId")
                        .HasColumnType("int");

                    b.Property<bool?>("RentWoorkSapce")
                        .HasColumnType("bit");

                    b.Property<int>("Roomid")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnName("userId")
                        .HasColumnType("int");

                    b.HasKey("IdBooking");

                    b.HasIndex("OfficeId");

                    b.HasIndex("UserId");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.Office", b =>
                {
                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("City")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<bool?>("HasIndividualWorkSpace")
                        .HasColumnType("bit");

                    b.Property<int?>("IdAdmin")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("NumberWorkSpace")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<decimal?>("PriceWorkSpaceDaily")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<decimal?>("PriceWorkSpaceMonthly")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("OfficeId");

                    b.HasIndex("IdAdmin");

                    b.ToTable("Office");
                });

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.OfficesToRoom", b =>
                {
                    b.Property<int>("OfficesToRoomId")
                        .HasColumnType("int");

                    b.Property<int?>("OfficeId")
                        .HasColumnType("int");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("OfficesToRoomId");

                    b.HasIndex("OfficeId");

                    b.HasIndex("RoomId");

                    b.ToTable("OfficesToRoom");
                });

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<int?>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("RoomId");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.RoomToService", b =>
                {
                    b.Property<int>("RoomToServiceId")
                        .HasColumnType("int");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("int");

                    b.HasKey("RoomToServiceId");

                    b.HasIndex("RoomId");

                    b.HasIndex("ServiceId");

                    b.ToTable("RoomToService");
                });

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("ServiceId");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CrateDate")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("SurName")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.Booking", b =>
                {
                    b.HasOne("Coworking.Api.DataAccess.Contracts.Entities.Office", "Office")
                        .WithMany("Booking")
                        .HasForeignKey("OfficeId")
                        .HasConstraintName("FK_Booking_Office");

                    b.HasOne("Coworking.Api.DataAccess.Contracts.Entities.User", "User")
                        .WithMany("Booking")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Booking_User");
                });

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.Office", b =>
                {
                    b.HasOne("Coworking.Api.DataAccess.Contracts.Entities.Admin", "IdAdminNavigation")
                        .WithMany("Office")
                        .HasForeignKey("IdAdmin")
                        .HasConstraintName("FK_Office_Admin");
                });

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.OfficesToRoom", b =>
                {
                    b.HasOne("Coworking.Api.DataAccess.Contracts.Entities.Office", "Office")
                        .WithMany("OfficesToRoom")
                        .HasForeignKey("OfficeId")
                        .HasConstraintName("FK_OfficesToRoom_Office");

                    b.HasOne("Coworking.Api.DataAccess.Contracts.Entities.Room", "Room")
                        .WithMany("OfficesToRoom")
                        .HasForeignKey("RoomId")
                        .HasConstraintName("FK_OfficesToRoom_Room");
                });

            modelBuilder.Entity("Coworking.Api.DataAccess.Contracts.Entities.RoomToService", b =>
                {
                    b.HasOne("Coworking.Api.DataAccess.Contracts.Entities.Room", "Room")
                        .WithMany("RoomToService")
                        .HasForeignKey("RoomId")
                        .HasConstraintName("FK_RoomToService_Room");

                    b.HasOne("Coworking.Api.DataAccess.Contracts.Entities.Service", "Service")
                        .WithMany("RoomToService")
                        .HasForeignKey("ServiceId")
                        .HasConstraintName("FK_RoomToService_Service");
                });
#pragma warning restore 612, 618
        }
    }
}