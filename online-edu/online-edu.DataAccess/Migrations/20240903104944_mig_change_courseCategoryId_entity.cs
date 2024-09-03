﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace online_edu.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_change_courseCategoryId_entity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseCategorys_CategoryId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Courses",
                newName: "CourseCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_CategoryId",
                table: "Courses",
                newName: "IX_Courses_CourseCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseCategorys_CourseCategoryId",
                table: "Courses",
                column: "CourseCategoryId",
                principalTable: "CourseCategorys",
                principalColumn: "CourseCategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseCategorys_CourseCategoryId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "CourseCategoryId",
                table: "Courses",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Courses_CourseCategoryId",
                table: "Courses",
                newName: "IX_Courses_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseCategorys_CategoryId",
                table: "Courses",
                column: "CategoryId",
                principalTable: "CourseCategorys",
                principalColumn: "CourseCategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
