using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETicaret.Apı.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig18 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quentity",
                table: "BasketItems",
                newName: "Quantity");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Baskets_Id",
                table: "Orders",
                column: "Id",
                principalTable: "Baskets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Baskets_Id",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "BasketItems",
                newName: "Quentity");
        }
    }
}
