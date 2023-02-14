using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebParse.Migrations
{
    /// <inheritdoc />
    public partial class dbOlusum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Oyuncular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyAd = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oyuncular", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Turler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IletisimBilgileri",
                columns: table => new
                {
                    OyuncuID = table.Column<int>(type: "int", nullable: false),
                    TelefonNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IletisimBilgileri", x => x.OyuncuID);
                    table.ForeignKey(
                        name: "FK_IletisimBilgileri_Oyuncular_OyuncuID",
                        column: x => x.OyuncuID,
                        principalTable: "Oyuncular",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Filmler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Yıl = table.Column<int>(type: "int", nullable: false),
                    imdbPuanı = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Poster = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imdbId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TurId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmler", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Filmler_Turler_TurId",
                        column: x => x.TurId,
                        principalTable: "Turler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmOyuncu",
                columns: table => new
                {
                    FilmsID = table.Column<int>(type: "int", nullable: false),
                    OyuncularId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmOyuncu", x => new { x.FilmsID, x.OyuncularId });
                    table.ForeignKey(
                        name: "FK_FilmOyuncu_Filmler_FilmsID",
                        column: x => x.FilmsID,
                        principalTable: "Filmler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmOyuncu_Oyuncular_OyuncularId",
                        column: x => x.OyuncularId,
                        principalTable: "Oyuncular",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filmler_TurId",
                table: "Filmler",
                column: "TurId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmOyuncu_OyuncularId",
                table: "FilmOyuncu",
                column: "OyuncularId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmOyuncu");

            migrationBuilder.DropTable(
                name: "IletisimBilgileri");

            migrationBuilder.DropTable(
                name: "Filmler");

            migrationBuilder.DropTable(
                name: "Oyuncular");

            migrationBuilder.DropTable(
                name: "Turler");
        }
    }
}
