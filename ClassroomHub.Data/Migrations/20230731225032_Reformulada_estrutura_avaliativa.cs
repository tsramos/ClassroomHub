using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassroomHub.Data.Migrations
{
    public partial class Reformulada_estrutura_avaliativa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Students_StudentId",
                table: "Activities");

            migrationBuilder.DropTable(
                name: "Deliveries");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Activities_StudentId",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Activities");

            migrationBuilder.AddColumn<Guid>(
                name: "Class",
                table: "Modules",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RoomIdId",
                table: "Modules",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeliveyDate",
                table: "Activities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "Activities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Resolution",
                table: "Activities",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Modules_RoomIdId",
                table: "Modules",
                column: "RoomIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Classes_RoomIdId",
                table: "Modules",
                column: "RoomIdId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Classes_RoomIdId",
                table: "Modules");

            migrationBuilder.DropIndex(
                name: "IX_Modules_RoomIdId",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "RoomIdId",
                table: "Modules");

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
                name: "StudentId",
                table: "Activities",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GradeValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GradeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GradeId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deliveries_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deliveries_Grades_GradeId",
                        column: x => x.GradeId,
                        principalTable: "Grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deliveries_Grades_GradeId1",
                        column: x => x.GradeId1,
                        principalTable: "Grades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_StudentId",
                table: "Activities",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_ActivityId",
                table: "Deliveries",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_GradeId",
                table: "Deliveries",
                column: "GradeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_GradeId1",
                table: "Deliveries",
                column: "GradeId1",
                unique: true,
                filter: "[GradeId1] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Students_StudentId",
                table: "Activities",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
