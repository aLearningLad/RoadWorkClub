using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoadWorkClub.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Path",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistanceInKm = table.Column<double>(type: "float", nullable: false),
                    AvgDuration = table.Column<TimeSpan>(type: "time", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsLoop = table.Column<bool>(type: "bit", nullable: false),
                    RecommendedStartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    DifficultyRating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Path", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stopovers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Neighbourhood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Landmarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PathId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stopovers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stopovers_Path_PathId",
                        column: x => x.PathId,
                        principalTable: "Path",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stopovers_PathId",
                table: "Stopovers",
                column: "PathId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stopovers");

            migrationBuilder.DropTable(
                name: "Path");
        }
    }
}
