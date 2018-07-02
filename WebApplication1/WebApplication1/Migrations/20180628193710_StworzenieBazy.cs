using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class StworzenieBazy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dostawcy",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Miejscowosc = table.Column<string>(nullable: true),
                    NazwaDostawcy = table.Column<string>(nullable: true),
                    RodzajDostawcy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dostawcy", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sklepy",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Miejscowosc = table.Column<string>(nullable: true),
                    NazwaSklepu = table.Column<string>(nullable: true),
                    RodzajSklepu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sklepy", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Towary",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Miejscowosc = table.Column<string>(nullable: true),
                    NazwaTowaru = table.Column<string>(nullable: true),
                    TypTowaru = table.Column<string>(nullable: true),
                    RozmiarTowaru = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towary", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dostawcy");

            migrationBuilder.DropTable(
                name: "Sklepy");

            migrationBuilder.DropTable(
                name: "Towary");
        }
    }
}
