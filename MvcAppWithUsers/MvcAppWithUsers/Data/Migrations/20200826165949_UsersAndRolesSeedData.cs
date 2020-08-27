using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcAppWithUsers.Data.Migrations
{
    public partial class UsersAndRolesSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddRole("Admin");
            migrationBuilder.AddRole("BackOfficeUser");
            migrationBuilder.AddRole("FrontOfficeUser");

            migrationBuilder.AddUserWithRoles(
               email: "admin@fasttrackit.ro",
               password: "Admin123!",
               new[] { "Admin", "BackOfficeUser", "FrontOfficeUser" });

            migrationBuilder.AddUserWithRoles(
                "back-office@fasttrackit.ro",
                "Backoffice123!",
                new[] { "BackOfficeUser" });

            migrationBuilder.AddUserWithRoles(
                "front-office@fasttrackit.ro",
                "Frontoffice123!",
                new[] { "FrontOfficeUser" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
