using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tattoohub.Migrations
{
    /// <inheritdoc />
    public partial class SmallChangesToModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artists_Shops_ShopId",
                table: "Artists");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtistStyle_Artists_ArtistId",
                table: "ArtistStyle");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtistStyle_Styles_StyleId",
                table: "ArtistStyle");

            migrationBuilder.DropForeignKey(
                name: "FK_Tattoos_Artists_ArtistId",
                table: "Tattoos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArtistStyle",
                table: "ArtistStyle");

            migrationBuilder.DropColumn(
                name: "Dimensions",
                table: "Tattoos");

            migrationBuilder.DropColumn(
                name: "ArtistName",
                table: "Artists");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Artists");

            migrationBuilder.RenameTable(
                name: "ArtistStyle",
                newName: "ArtistStyles");

            migrationBuilder.RenameIndex(
                name: "IX_ArtistStyle_StyleId",
                table: "ArtistStyles",
                newName: "IX_ArtistStyles_StyleId");

            migrationBuilder.AlterColumn<int>(
                name: "BodyPlacement",
                table: "Tattoos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "ArtistId",
                table: "Tattoos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TattooSize",
                table: "Tattoos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ShopId",
                table: "Artists",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArtistStyles",
                table: "ArtistStyles",
                columns: new[] { "ArtistId", "StyleId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Artists_Shops_ShopId",
                table: "Artists",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "ShopId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistStyles_Artists_ArtistId",
                table: "ArtistStyles",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistStyles_Styles_StyleId",
                table: "ArtistStyles",
                column: "StyleId",
                principalTable: "Styles",
                principalColumn: "StyleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tattoos_Artists_ArtistId",
                table: "Tattoos",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artists_Shops_ShopId",
                table: "Artists");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtistStyles_Artists_ArtistId",
                table: "ArtistStyles");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtistStyles_Styles_StyleId",
                table: "ArtistStyles");

            migrationBuilder.DropForeignKey(
                name: "FK_Tattoos_Artists_ArtistId",
                table: "Tattoos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArtistStyles",
                table: "ArtistStyles");

            migrationBuilder.DropColumn(
                name: "TattooSize",
                table: "Tattoos");

            migrationBuilder.RenameTable(
                name: "ArtistStyles",
                newName: "ArtistStyle");

            migrationBuilder.RenameIndex(
                name: "IX_ArtistStyles_StyleId",
                table: "ArtistStyle",
                newName: "IX_ArtistStyle_StyleId");

            migrationBuilder.AlterColumn<string>(
                name: "BodyPlacement",
                table: "Tattoos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ArtistId",
                table: "Tattoos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Dimensions",
                table: "Tattoos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "ShopId",
                table: "Artists",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArtistName",
                table: "Artists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Artists",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArtistStyle",
                table: "ArtistStyle",
                columns: new[] { "ArtistId", "StyleId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Artists_Shops_ShopId",
                table: "Artists",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistStyle_Artists_ArtistId",
                table: "ArtistStyle",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistStyle_Styles_StyleId",
                table: "ArtistStyle",
                column: "StyleId",
                principalTable: "Styles",
                principalColumn: "StyleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tattoos_Artists_ArtistId",
                table: "Tattoos",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "ArtistId");
        }
    }
}
