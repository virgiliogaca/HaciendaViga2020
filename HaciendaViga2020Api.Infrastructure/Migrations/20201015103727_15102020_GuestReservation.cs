using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HaciendaViga2020Api.Infrastructure.Migrations
{
    public partial class _15102020_GuestReservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomTypes",
                table: "RoomTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "Reservation",
                newName: "Reservation",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "RoomTypes",
                newName: "RoomType",
                newSchema: "dbo");

            migrationBuilder.RenameTable(
                name: "Rooms",
                newName: "Room",
                newSchema: "dbo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomType",
                schema: "dbo",
                table: "RoomType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Room",
                schema: "dbo",
                table: "Room",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "BookExternalClientReservation",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExternalClientCatalogId = table.Column<Guid>(nullable: false),
                    ReservationId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookExternalClientReservation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExternalClientCatalog",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(maxLength: 128, nullable: true),
                    CreatedBy = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 128, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Url = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalClientCatalog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guest",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(maxLength: 128, nullable: true),
                    CreatedBy = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 128, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    FirstSurname = table.Column<string>(nullable: true),
                    Address1 = table.Column<string>(nullable: false),
                    Address2 = table.Column<string>(nullable: true),
                    HomePhoneNumber = table.Column<int>(nullable: false),
                    CellPhoneNumber = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guest", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GuestReservation",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    GuestId = table.Column<Guid>(nullable: false),
                    ReservationId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuestReservation", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookExternalClientReservation",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ExternalClientCatalog",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Guest",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "GuestReservation",
                schema: "dbo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomType",
                schema: "dbo",
                table: "RoomType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Room",
                schema: "dbo",
                table: "Room");

            migrationBuilder.RenameTable(
                name: "Reservation",
                schema: "dbo",
                newName: "Reservation");

            migrationBuilder.RenameTable(
                name: "RoomType",
                schema: "dbo",
                newName: "RoomTypes");

            migrationBuilder.RenameTable(
                name: "Room",
                schema: "dbo",
                newName: "Rooms");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomTypes",
                table: "RoomTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms",
                column: "Id");
        }
    }
}
