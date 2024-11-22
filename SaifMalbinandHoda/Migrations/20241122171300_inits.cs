using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaifMalbinandHoda.Migrations
{
    public partial class inits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Published_year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoriesId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Directos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Directos_Nationalities_NationalityId",
                        column: x => x.NationalityId,
                        principalTable: "Nationalities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DirectosMovies",
                columns: table => new
                {
                    DirectosId = table.Column<int>(type: "int", nullable: false),
                    MoviesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectosMovies", x => new { x.DirectosId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_DirectosMovies_Directos_DirectosId",
                        column: x => x.DirectosId,
                        principalTable: "Directos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DirectosMovies_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Directos_NationalityId",
                table: "Directos",
                column: "NationalityId",
                unique: true,
                filter: "[NationalityId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DirectosMovies_MoviesId",
                table: "DirectosMovies",
                column: "MoviesId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CategoriesId",
                table: "Movies",
                column: "CategoriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DirectosMovies");

            migrationBuilder.DropTable(
                name: "Directos");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
