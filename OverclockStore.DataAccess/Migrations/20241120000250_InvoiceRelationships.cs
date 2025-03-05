using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OverclockStore.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InvoiceRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Products_Productid",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Users_Userid",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_Productid",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_Userid",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "Productid",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "Userid",
                table: "Invoices");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_idProduct",
                table: "Invoices",
                column: "idProduct");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_idUser",
                table: "Invoices",
                column: "idUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Products_idProduct",
                table: "Invoices",
                column: "idProduct",
                principalTable: "Products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Users_idUser",
                table: "Invoices",
                column: "idUser",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Products_idProduct",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Users_idUser",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_idProduct",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_idUser",
                table: "Invoices");

            migrationBuilder.AddColumn<int>(
                name: "Productid",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Userid",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_Productid",
                table: "Invoices",
                column: "Productid");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_Userid",
                table: "Invoices",
                column: "Userid");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Products_Productid",
                table: "Invoices",
                column: "Productid",
                principalTable: "Products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Users_Userid",
                table: "Invoices",
                column: "Userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
