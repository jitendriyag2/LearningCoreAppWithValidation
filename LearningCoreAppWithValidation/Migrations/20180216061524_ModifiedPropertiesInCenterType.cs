using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LearningCoreAppWithValidation.Migrations
{
    public partial class ModifiedPropertiesInCenterType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CenterTypes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShortName",
                table: "CenterTypes",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IsActive",
                table: "CenterTypes",
                defaultValue: 1);
            migrationBuilder.AlterColumn<string>(
               name: "Name",
               maxLength : 30,
               table: "CenterTypes");

            migrationBuilder.AddUniqueConstraint("CenterType_Name_Unique", "CenterTypes", "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "CenterTypes");

            migrationBuilder.DropColumn(
                name: "ShortName",
                table: "CenterTypes");

            migrationBuilder.AlterColumn<string>(
               name: "IsActive",
               table: "CenterTypes",
               defaultValue: 1);
            migrationBuilder.AlterColumn<string>(
               name: "Name",
               maxLength: 30,
               table: "CenterTypes");

            migrationBuilder.AddUniqueConstraint("CenterType_Name_Unique", "CenterTypes", "Name");
        }
    }
}
