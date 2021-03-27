using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HaciendaViga2020Api.Infrastructure.Migrations
{
    public partial class InitialMigration_13102020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(maxLength: 128, nullable: true),
                    CreatedBy = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 128, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    RoomId = table.Column<Guid>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    PeopleAmount = table.Column<int>(nullable: false),
                    IsCanceled = table.Column<bool>(nullable: false),
                    CanceledBy = table.Column<string>(nullable: true),
                    CancelationDate = table.Column<DateTime>(nullable: false),
                    IsExternalCliend = table.Column<bool>(nullable: false),
                    IsPayed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(maxLength: 128, nullable: true),
                    CreatedBy = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 128, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    RoomTypeId = table.Column<Guid>(nullable: false),
                    RoomNumber = table.Column<int>(nullable: false),
                    RoomTelephone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(maxLength: 128, nullable: true),
                    CreatedBy = table.Column<string>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 128, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Cost = table.Column<double>(nullable: false),
                    RoomAmount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "RoomTypes");
        }
    }
}
