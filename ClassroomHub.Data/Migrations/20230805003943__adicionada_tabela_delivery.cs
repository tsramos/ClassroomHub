using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassroomHub.Data.Migrations
{
    public partial class _adicionada_tabela_delivery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeliveyDate",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "Resolution",
                table: "Activities");

            migrationBuilder.AddColumn<Guid>(
                name: "DeliveryId",
                table: "Activities",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Delivery",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DeliveyDate = table.Column<DateTime>(nullable: false),
                    Resolution = table.Column<string>(nullable: false),
                    Grade = table.Column<int>(nullable: false),
                    StudentId = table.Column<Guid>(nullable: false),
                    ActivityId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Delivery_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_DeliveryId",
                table: "Activities",
                column: "DeliveryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_StudentId",
                table: "Delivery",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Delivery_DeliveryId",
                table: "Activities",
                column: "DeliveryId",
                principalTable: "Delivery",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Delivery_DeliveryId",
                table: "Activities");

            migrationBuilder.DropTable(
                name: "Delivery");

            migrationBuilder.DropIndex(
                name: "IX_Activities_DeliveryId",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "DeliveryId",
                table: "Activities");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveyDate",
                table: "Activities",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "Activities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Resolution",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
