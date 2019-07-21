using Microsoft.EntityFrameworkCore.Migrations;

namespace JuniorTask.Migrations
{
    public partial class EAV_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personAttributes_People_personId",
                table: "personAttributes");

            migrationBuilder.AlterColumn<string>(
                name: "personId",
                table: "personAttributes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_personAttributes_People_personId",
                table: "personAttributes",
                column: "personId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personAttributes_People_personId",
                table: "personAttributes");

            migrationBuilder.AlterColumn<string>(
                name: "personId",
                table: "personAttributes",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_personAttributes_People_personId",
                table: "personAttributes",
                column: "personId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
