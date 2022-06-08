using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataContextStructure.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "First",
                table: "transactionModels",
                newName: "TransactionAmount");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "transactionModels",
                newName: "Firstname");

            migrationBuilder.AddColumn<bool>(
                name: "TransactionStatus",
                table: "transactionModels",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionStatus",
                table: "transactionModels");

            migrationBuilder.RenameColumn(
                name: "TransactionAmount",
                table: "transactionModels",
                newName: "First");

            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "transactionModels",
                newName: "Amount");
        }
    }
}
