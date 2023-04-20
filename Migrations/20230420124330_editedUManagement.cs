using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vehicle_Parking_Management_System.Migrations
{
    public partial class editedUManagement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "UserManagement");

            migrationBuilder.DropColumn(
                name: "Contact",
                table: "UserManagement");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "UserManagement");

            migrationBuilder.DropColumn(
                name: "FirstNmae",
                table: "UserManagement");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "UserManagement");

            migrationBuilder.AlterColumn<string>(
                name: "UserCategory",
                table: "UserManagement",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "UserManagement",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserManagement_ApplicationUserId",
                table: "UserManagement",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserManagement_AspNetUsers_ApplicationUserId",
                table: "UserManagement",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserManagement_AspNetUsers_ApplicationUserId",
                table: "UserManagement");

            migrationBuilder.DropIndex(
                name: "IX_UserManagement_ApplicationUserId",
                table: "UserManagement");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "UserManagement");

            migrationBuilder.AlterColumn<string>(
                name: "UserCategory",
                table: "UserManagement",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "UserManagement",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "UserManagement",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "UserManagement",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstNmae",
                table: "UserManagement",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "UserManagement",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
