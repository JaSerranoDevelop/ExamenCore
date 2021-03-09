using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BPT.Test.JASM.BackEnd.DataAccess.Migrations
{
    public partial class AddModelStudentAssigment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudenAssigments_Assignments_Id",
                table: "StudenAssigments");

            migrationBuilder.DropForeignKey(
                name: "FK_StudenAssigments_Students_Id",
                table: "StudenAssigments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudenAssigments",
                table: "StudenAssigments");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StudenAssigments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudenAssigments",
                table: "StudenAssigments",
                columns: new[] { "IdAssignments", "IdStudent" });

            migrationBuilder.CreateIndex(
                name: "IX_StudenAssigments_IdStudent",
                table: "StudenAssigments",
                column: "IdStudent");

            migrationBuilder.AddForeignKey(
                name: "FK_StudenAssigments_Assignments_IdAssignments",
                table: "StudenAssigments",
                column: "IdAssignments",
                principalTable: "Assignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudenAssigments_Students_IdStudent",
                table: "StudenAssigments",
                column: "IdStudent",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudenAssigments_Assignments_IdAssignments",
                table: "StudenAssigments");

            migrationBuilder.DropForeignKey(
                name: "FK_StudenAssigments_Students_IdStudent",
                table: "StudenAssigments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudenAssigments",
                table: "StudenAssigments");

            migrationBuilder.DropIndex(
                name: "IX_StudenAssigments_IdStudent",
                table: "StudenAssigments");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "StudenAssigments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudenAssigments",
                table: "StudenAssigments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudenAssigments_Assignments_Id",
                table: "StudenAssigments",
                column: "Id",
                principalTable: "Assignments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudenAssigments_Students_Id",
                table: "StudenAssigments",
                column: "Id",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
