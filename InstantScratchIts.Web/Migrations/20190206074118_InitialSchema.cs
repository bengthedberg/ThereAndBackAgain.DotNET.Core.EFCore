using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InstantScratchIts.Web.Migrations
{
    public partial class InitialSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InstantGames",
                columns: table => new
                {
                    InstantGameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GameNo = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    TicketAmount = table.Column<decimal>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstantGames", x => x.InstantGameId);
                });

            migrationBuilder.CreateTable(
                name: "Jurisdiction",
                columns: table => new
                {
                    JurisdictionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InstantGameId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RetailCommissionAmount = table.Column<decimal>(nullable: false),
                    StartSellDate = table.Column<DateTime>(nullable: false),
                    StopSellDate = table.Column<DateTime>(nullable: false),
                    ValidationPeriod = table.Column<TimeSpan>(nullable: false),
                    Allocation = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jurisdiction", x => x.JurisdictionId);
                    table.ForeignKey(
                        name: "FK_Jurisdiction_InstantGames_InstantGameId",
                        column: x => x.InstantGameId,
                        principalTable: "InstantGames",
                        principalColumn: "InstantGameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jurisdiction_InstantGameId",
                table: "Jurisdiction",
                column: "InstantGameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jurisdiction");

            migrationBuilder.DropTable(
                name: "InstantGames");
        }
    }
}
