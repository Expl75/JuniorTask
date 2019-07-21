using Microsoft.EntityFrameworkCore.Migrations;

namespace JuniorTask.Migrations
{
    public partial class PersonEAV_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personAttributes_People_personId",
                table: "personAttributes");

            migrationBuilder.RenameColumn(
                name: "personId",
                table: "personAttributes",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_personAttributes_personId",
                table: "personAttributes",
                newName: "IX_personAttributes_PersonId");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "People",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_personAttributes_People_PersonId",
                table: "personAttributes",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personAttributes_People_PersonId",
                table: "personAttributes");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "People");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "personAttributes",
                newName: "personId");

            migrationBuilder.RenameIndex(
                name: "IX_personAttributes_PersonId",
                table: "personAttributes",
                newName: "IX_personAttributes_personId");

            migrationBuilder.AddForeignKey(
                name: "FK_personAttributes_People_personId",
                table: "personAttributes",
                column: "personId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
