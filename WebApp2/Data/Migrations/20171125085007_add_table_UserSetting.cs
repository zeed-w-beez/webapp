using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace WebApp2.Data.Migrations
{
    public partial class add_table_UserSetting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserSettingId",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AspNetRoles",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserSetting",
                columns: table => new
                {
                    UserSettingId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Language = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Theme = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSetting", x => x.UserSettingId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserSettingId",
                table: "AspNetUsers",
                column: "UserSettingId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_UserSetting_UserSettingId",
                table: "AspNetUsers",
                column: "UserSettingId",
                principalTable: "UserSetting",
                principalColumn: "UserSettingId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_UserSetting_UserSettingId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "UserSetting");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_UserSettingId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserSettingId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AspNetRoles");
        }
    }
}
