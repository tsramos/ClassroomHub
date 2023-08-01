using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassroomHub.Data.Migrations
{
    public partial class corrigido_Relacionamento_Module_Class : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "ClassId",
                table: "Modules",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Modules_ClassId",
                table: "Modules",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Modules_Classes_ClassId",
                table: "Modules",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modules_Classes_ClassId",
                table: "Modules");

            migrationBuilder.DropIndex(
                name: "IX_Modules_ClassId",
                table: "Modules");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Modules");

            migrationBuilder.AddColumn<Guid>(
                name: "Class",
                table: "Modules",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RoomIdId",
                table: "Modules",
                type: "uniqueidentifier",
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
    }
}
