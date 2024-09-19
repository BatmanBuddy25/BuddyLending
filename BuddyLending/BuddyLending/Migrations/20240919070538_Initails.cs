using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuddyLending.Migrations
{
    /// <inheritdoc />
    public partial class Initails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InterestRateTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterestRate = table.Column<double>(type: "float", nullable: false),
                    InterestDesc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterestRateTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LendDetailsTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LendNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LoanBalanceAmount = table.Column<double>(type: "float", nullable: false),
                    RuturnAmount = table.Column<double>(type: "float", nullable: false),
                    InterestAmount = table.Column<double>(type: "float", nullable: false),
                    TotalAmount = table.Column<double>(type: "float", nullable: false),
                    LendStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceiveName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LendDetailsTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MemberTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Civil = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CBU = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferralId = table.Column<int>(type: "int", nullable: false),
                    ReferralName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LendHeaderTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LendNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplyCount = table.Column<int>(type: "int", nullable: false),
                    MemModelId = table.Column<int>(type: "int", nullable: false),
                    DateApply = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LendStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferralId = table.Column<int>(type: "int", nullable: false),
                    ReferralName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmountApply = table.Column<double>(type: "float", nullable: false),
                    AmountApproved = table.Column<double>(type: "float", nullable: false),
                    AmountInterest = table.Column<double>(type: "float", nullable: false),
                    AmountTotal = table.Column<double>(type: "float", nullable: false),
                    AmountRemittance = table.Column<double>(type: "float", nullable: false),
                    IntRateMId = table.Column<int>(type: "int", nullable: false),
                    DateApproved = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateClosed = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LendHeaderTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LendHeaderTable_InterestRateTable_IntRateMId",
                        column: x => x.IntRateMId,
                        principalTable: "InterestRateTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LendHeaderTable_MemberTable_MemModelId",
                        column: x => x.MemModelId,
                        principalTable: "MemberTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LendHeaderTable_IntRateMId",
                table: "LendHeaderTable",
                column: "IntRateMId");

            migrationBuilder.CreateIndex(
                name: "IX_LendHeaderTable_MemModelId",
                table: "LendHeaderTable",
                column: "MemModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LendDetailsTable");

            migrationBuilder.DropTable(
                name: "LendHeaderTable");

            migrationBuilder.DropTable(
                name: "InterestRateTable");

            migrationBuilder.DropTable(
                name: "MemberTable");
        }
    }
}
