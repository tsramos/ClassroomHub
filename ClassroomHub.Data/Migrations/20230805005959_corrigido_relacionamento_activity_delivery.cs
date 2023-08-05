using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassroomHub.Data.Migrations
{
    public partial class corrigido_relacionamento_activity_delivery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Delivery_DeliveryId",
                table: "Activities");

            migrationBuilder.DropIndex(
                name: "IX_Activities_DeliveryId",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "DeliveryId",
                table: "Activities");

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_ActivityId",
                table: "Delivery",
                column: "ActivityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Delivery_Activities_ActivityId",
                table: "Delivery",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Delivery_Activities_ActivityId",
                table: "Delivery");

            migrationBuilder.DropIndex(
                name: "IX_Delivery_ActivityId",
                table: "Delivery");

            migrationBuilder.AddColumn<Guid>(
                name: "DeliveryId",
                table: "Activities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Activities_DeliveryId",
                table: "Activities",
                column: "DeliveryId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Delivery_DeliveryId",
                table: "Activities",
                column: "DeliveryId",
                principalTable: "Delivery",
                principalColumn: "Id");
        }
    }
}
