using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HFProject.Migrations
{
    public partial class foreignkeyfix1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Appointment_CustomerId",
                table: "Appointment",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Customers_CustomerId",
                table: "Appointment",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Customers_CustomerId",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_CustomerId",
                table: "Appointment");
        }
    }
}
