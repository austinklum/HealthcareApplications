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
                    SecQ1Index = table.Column<int>(type: "int", nullable: false),
                    SecQ1Response = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecQ2Index = table.Column<int>(type: "int", nullable: false),
                    SecQ2Response = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecQ3Index = table.Column<int>(type: "int", nullable: false),
                    SecQ3Response = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
