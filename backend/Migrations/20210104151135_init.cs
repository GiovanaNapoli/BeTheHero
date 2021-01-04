using Microsoft.EntityFrameworkCore.Migrations;

namespace backend.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ongs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Whatsapp = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Uf = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ongs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Incidents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Value = table.Column<double>(type: "REAL", nullable: false),
                    OngId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Incidents_Ongs_OngId",
                        column: x => x.OngId,
                        principalTable: "Ongs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ongs",
                columns: new[] { "Id", "City", "Email", "Name", "Uf", "Whatsapp" },
                values: new object[] { 1, "Mongaguá", "contato.apae.com.br", "APAE", "SP", "13987653498" });

            migrationBuilder.InsertData(
                table: "Ongs",
                columns: new[] { "Id", "City", "Email", "Name", "Uf", "Whatsapp" },
                values: new object[] { 2, "Praia Grande", "contato.estrelamama.com.br", "Estrela da Mama", "SP", "13987653498" });

            migrationBuilder.InsertData(
                table: "Ongs",
                columns: new[] { "Id", "City", "Email", "Name", "Uf", "Whatsapp" },
                values: new object[] { 3, "São Vicente", "contato.vadaporvidas.com.br", "Vida Por Vidas", "SP", "13987653498" });

            migrationBuilder.InsertData(
                table: "Ongs",
                columns: new[] { "Id", "City", "Email", "Name", "Uf", "Whatsapp" },
                values: new object[] { 4, "Itanhaém", "contato.mangue.com.br", "Pró Mangue", "SP", "13987653498" });

            migrationBuilder.InsertData(
                table: "Ongs",
                columns: new[] { "Id", "City", "Email", "Name", "Uf", "Whatsapp" },
                values: new object[] { 5, "Santos", "contato.vivabicho.com.br", "Viva Bicho Santos", "SP", "13987653498" });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "Id", "Description", "OngId", "Title", "Value" },
                values: new object[] { 1, "Arrecadação de fundos para a compra de cadeiras de rodas para crianças necessitadas", 1, "Compra de cadeira de rodas", 12.0 });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "Id", "Description", "OngId", "Title", "Value" },
                values: new object[] { 2, "Arrecadação de fundos para a compra de perucas para mulheres que estão passando pela quimioterapia", 2, "Compra de perucas", 12.0 });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "Id", "Description", "OngId", "Title", "Value" },
                values: new object[] { 3, "Arrecadação de fundos para a compra de cestas basicas", 3, "Compra de cestas basicas", 12.0 });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "Id", "Description", "OngId", "Title", "Value" },
                values: new object[] { 4, "Arrecadação de fundos para a compra de equipamentos para revitalização dos mangues", 4, "Compra de de equipamento", 12.0 });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "Id", "Description", "OngId", "Title", "Value" },
                values: new object[] { 5, "Arrecadação de fundos para a compra de ração", 5, "Compra de ração", 12.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_OngId",
                table: "Incidents",
                column: "OngId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incidents");

            migrationBuilder.DropTable(
                name: "Ongs");
        }
    }
}
