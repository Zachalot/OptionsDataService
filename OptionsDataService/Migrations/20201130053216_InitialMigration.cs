using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OptionsDataService.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equities",
                columns: table => new
                {
                    EquityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Close = table.Column<float>(type: "real", nullable: false),
                    QuoteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bid = table.Column<float>(type: "real", nullable: false),
                    Ask = table.Column<float>(type: "real", nullable: false),
                    Last = table.Column<float>(type: "real", nullable: false),
                    Mark = table.Column<float>(type: "real", nullable: false),
                    BidSize = table.Column<int>(type: "int", nullable: false),
                    AskSize = table.Column<int>(type: "int", nullable: false),
                    HighPrice = table.Column<float>(type: "real", nullable: false),
                    LowPrice = table.Column<float>(type: "real", nullable: false),
                    OpenPrice = table.Column<float>(type: "real", nullable: false),
                    TotalVolume = table.Column<int>(type: "int", nullable: false),
                    High52Wk = table.Column<float>(type: "real", nullable: false),
                    Low52Wk = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equities", x => x.EquityId);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    OptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OptionableEquityId = table.Column<int>(type: "int", nullable: false),
                    SymbolUnderlying = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuoteTimeUnderlying = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MarkUnderlying = table.Column<float>(type: "real", nullable: false),
                    ContractType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bid = table.Column<float>(type: "real", nullable: false),
                    Ask = table.Column<float>(type: "real", nullable: false),
                    Mark = table.Column<float>(type: "real", nullable: false),
                    BidSize = table.Column<int>(type: "int", nullable: false),
                    AskSize = table.Column<int>(type: "int", nullable: false),
                    HighPrice = table.Column<float>(type: "real", nullable: false),
                    LowPrice = table.Column<float>(type: "real", nullable: false),
                    OpenPrice = table.Column<float>(type: "real", nullable: false),
                    ClosePrice = table.Column<float>(type: "real", nullable: false),
                    TotalVolume = table.Column<int>(type: "int", nullable: false),
                    QuoteTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Volatility = table.Column<float>(type: "real", nullable: false),
                    Delta = table.Column<float>(type: "real", nullable: false),
                    Gamma = table.Column<float>(type: "real", nullable: false),
                    Theta = table.Column<float>(type: "real", nullable: false),
                    Vega = table.Column<float>(type: "real", nullable: false),
                    Rho = table.Column<float>(type: "real", nullable: false),
                    OpenInterest = table.Column<int>(type: "int", nullable: false),
                    TheoValue = table.Column<float>(type: "real", nullable: false),
                    TheoVolatility = table.Column<int>(type: "int", nullable: false),
                    Strike = table.Column<int>(type: "int", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dte = table.Column<int>(type: "int", nullable: false),
                    PercentChange = table.Column<float>(type: "real", nullable: false),
                    Itm = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.OptionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equities");

            migrationBuilder.DropTable(
                name: "Options");
        }
    }
}
