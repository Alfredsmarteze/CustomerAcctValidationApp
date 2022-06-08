using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataContextStructure.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_transactionModels",
                table: "transactionModels");

            migrationBuilder.RenameTable(
                name: "transactionModels",
                newName: "transactionTbl");

            migrationBuilder.AddPrimaryKey(
                name: "PK_transactionTbl",
                table: "transactionTbl",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_transactionTbl",
                table: "transactionTbl");

            migrationBuilder.RenameTable(
                name: "transactionTbl",
                newName: "transactionModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_transactionModels",
                table: "transactionModels",
                column: "Id");
        }
    }
}
