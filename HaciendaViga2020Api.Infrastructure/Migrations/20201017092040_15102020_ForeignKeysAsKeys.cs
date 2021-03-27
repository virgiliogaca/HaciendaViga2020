using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HaciendaViga2020Api.Infrastructure.Migrations
{
    public partial class _15102020_ForeignKeysAsKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GuestReservation",
                schema: "dbo",
                table: "GuestReservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookExternalClientReservation",
                schema: "dbo",
                table: "BookExternalClientReservation");

            migrationBuilder.DropColumn(
                name: "Id",
                schema: "dbo",
                table: "GuestReservation");

            migrationBuilder.DropColumn(
                name: "Id",
                schema: "dbo",
                table: "BookExternalClientReservation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GuestReservation",
                schema: "dbo",
                table: "GuestReservation",
                columns: new[] { "GuestId", "ReservationId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookExternalClientReservation",
                schema: "dbo",
                table: "BookExternalClientReservation",
                columns: new[] { "ReservationId", "ExternalClientCatalogId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GuestReservation",
                schema: "dbo",
                table: "GuestReservation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookExternalClientReservation",
                schema: "dbo",
                table: "BookExternalClientReservation");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                schema: "dbo",
                table: "GuestReservation",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                schema: "dbo",
                table: "BookExternalClientReservation",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_GuestReservation",
                schema: "dbo",
                table: "GuestReservation",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookExternalClientReservation",
                schema: "dbo",
                table: "BookExternalClientReservation",
                column: "Id");
        }
    }
}
