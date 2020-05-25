using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Coworking.Api.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    IdAdmin = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Phone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.IdAdmin);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    RoomId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Capacity = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.RoomId);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    ServiceId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.ServiceId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    SurName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    CrateDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Office",
                columns: table => new
                {
                    OfficeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Phone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    City = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Active = table.Column<bool>(nullable: true),
                    HasIndividualWorkSpace = table.Column<bool>(nullable: true),
                    NumberWorkSpace = table.Column<int>(nullable: true),
                    PriceWorkSpaceDaily = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    PriceWorkSpaceMonthly = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    IdAdmin = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Office", x => x.OfficeId);
                    table.ForeignKey(
                        name: "FK_Office_Admin",
                        column: x => x.IdAdmin,
                        principalTable: "Admin",
                        principalColumn: "IdAdmin",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomToService",
                columns: table => new
                {
                    RoomToServiceId = table.Column<int>(nullable: false),
                    ServiceId = table.Column<int>(nullable: true),
                    RoomId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomToService", x => x.RoomToServiceId);
                    table.ForeignKey(
                        name: "FK_RoomToService_Room",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomToService_Service",
                        column: x => x.ServiceId,
                        principalTable: "Service",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    IdBooking = table.Column<int>(nullable: false),
                    BookinDate = table.Column<DateTime>(type: "date", nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    RentWoorkSapce = table.Column<bool>(nullable: true),
                    Roomid = table.Column<int>(nullable: false),
                    userId = table.Column<int>(nullable: true),
                    OfficeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.IdBooking);
                    table.ForeignKey(
                        name: "FK_Booking_Office",
                        column: x => x.OfficeId,
                        principalTable: "Office",
                        principalColumn: "OfficeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Booking_User",
                        column: x => x.userId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OfficesToRoom",
                columns: table => new
                {
                    OfficesToRoomId = table.Column<int>(nullable: false),
                    OfficeId = table.Column<int>(nullable: true),
                    RoomId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficesToRoom", x => x.OfficesToRoomId);
                    table.ForeignKey(
                        name: "FK_OfficesToRoom_Office",
                        column: x => x.OfficeId,
                        principalTable: "Office",
                        principalColumn: "OfficeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OfficesToRoom_Room",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "RoomId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_OfficeId",
                table: "Booking",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_userId",
                table: "Booking",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Office_IdAdmin",
                table: "Office",
                column: "IdAdmin");

            migrationBuilder.CreateIndex(
                name: "IX_OfficesToRoom_OfficeId",
                table: "OfficesToRoom",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_OfficesToRoom_RoomId",
                table: "OfficesToRoom",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomToService_RoomId",
                table: "RoomToService",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomToService_ServiceId",
                table: "RoomToService",
                column: "ServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "OfficesToRoom");

            migrationBuilder.DropTable(
                name: "RoomToService");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Office");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Admin");
        }
    }
}
