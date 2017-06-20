using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace aspnetcoreapp.Migrations
{
    public partial class User_Table_Deleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionareSet_UsersSet_UserId",
                table: "QuestionareSet");

            migrationBuilder.DropTable(
                name: "UsersSet");

            migrationBuilder.DropIndex(
                name: "IX_QuestionareSet_UserId",
                table: "QuestionareSet");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "QuestionareSet");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "QuestionareSet",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UsersSet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MembershipId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersSet", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionareSet_UserId",
                table: "QuestionareSet",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionareSet_UsersSet_UserId",
                table: "QuestionareSet",
                column: "UserId",
                principalTable: "UsersSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
