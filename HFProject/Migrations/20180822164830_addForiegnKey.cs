using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HFProject.Migrations
{
    public partial class addForiegnKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Appointment",
                newName: "CustomerId");

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

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Appointment",
                newName: "UserId");
        }
    }
}
