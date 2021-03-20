using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthcareApplications.Migrations.User
{
    public partial class UserContextCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountStatus = table.Column<int>(type: "int", nullable: false),
                    SecurityQuestionIndex1 = table.Column<int>(type: "int", nullable: false),
                    SecurityQuestionResponse1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityQuestionIndex2 = table.Column<int>(type: "int", nullable: false),
                    SecurityQuestionResponse2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityQuestionIndex3 = table.Column<int>(type: "int", nullable: false),
                    SecurityQuestionResponse3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
