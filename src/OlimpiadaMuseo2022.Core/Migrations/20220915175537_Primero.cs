using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OlimpiadaMuseo2022.Core.Migrations
{
    public partial class Primero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Artista",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nacimiento = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artista", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Museo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Fundacion = table.Column<DateOnly>(type: "date", nullable: false),
                    Direccion = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Museo", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Plano",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdMuseo = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plano", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Plano_Museo_IdMuseo",
                        column: x => x.IdMuseo,
                        principalTable: "Museo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Exposicion",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdSala = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exposicion", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Obra",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdArtista = table.Column<int>(type: "int", nullable: false),
                    IdExposicion = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tipo = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descripcion = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obra", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Obra_Artista_IdArtista",
                        column: x => x.IdArtista,
                        principalTable: "Artista",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Obra_Exposicion_IdExposicion",
                        column: x => x.IdExposicion,
                        principalTable: "Exposicion",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Sala",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdMuseo = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CVisitaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sala", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sala_Museo_IdMuseo",
                        column: x => x.IdMuseo,
                        principalTable: "Museo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Turno",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdVisita = table.Column<int>(type: "int", nullable: false),
                    IdVisitante = table.Column<int>(type: "int", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turno", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Visita",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdMuseo = table.Column<int>(type: "int", nullable: false),
                    IdGuia = table.Column<int>(type: "int", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visita", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Visita_Museo_IdMuseo",
                        column: x => x.IdMuseo,
                        principalTable: "Museo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Visitante",
                columns: table => new
                {
                    DNI = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CVisitaID = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nacimiento = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitante", x => x.DNI);
                    table.ForeignKey(
                        name: "FK_Visitante_Visita_CVisitaID",
                        column: x => x.CVisitaID,
                        principalTable: "Visita",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Exposicion_IdSala",
                table: "Exposicion",
                column: "IdSala");

            migrationBuilder.CreateIndex(
                name: "IX_Obra_IdArtista",
                table: "Obra",
                column: "IdArtista");

            migrationBuilder.CreateIndex(
                name: "IX_Obra_IdExposicion",
                table: "Obra",
                column: "IdExposicion");

            migrationBuilder.CreateIndex(
                name: "IX_Plano_IdMuseo",
                table: "Plano",
                column: "IdMuseo");

            migrationBuilder.CreateIndex(
                name: "IX_Sala_CVisitaID",
                table: "Sala",
                column: "CVisitaID");

            migrationBuilder.CreateIndex(
                name: "IX_Sala_IdMuseo",
                table: "Sala",
                column: "IdMuseo");

            migrationBuilder.CreateIndex(
                name: "IX_Turno_IdVisita",
                table: "Turno",
                column: "IdVisita");

            migrationBuilder.CreateIndex(
                name: "IX_Turno_IdVisitante",
                table: "Turno",
                column: "IdVisitante");

            migrationBuilder.CreateIndex(
                name: "IX_Visita_IdGuia",
                table: "Visita",
                column: "IdGuia");

            migrationBuilder.CreateIndex(
                name: "IX_Visita_IdMuseo",
                table: "Visita",
                column: "IdMuseo");

            migrationBuilder.CreateIndex(
                name: "IX_Visitante_CVisitaID",
                table: "Visitante",
                column: "CVisitaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Exposicion_Sala_IdSala",
                table: "Exposicion",
                column: "IdSala",
                principalTable: "Sala",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sala_Visita_CVisitaID",
                table: "Sala",
                column: "CVisitaID",
                principalTable: "Visita",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Turno_Visita_IdVisita",
                table: "Turno",
                column: "IdVisita",
                principalTable: "Visita",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Turno_Visitante_IdVisitante",
                table: "Turno",
                column: "IdVisitante",
                principalTable: "Visitante",
                principalColumn: "DNI",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visita_Visitante_IdGuia",
                table: "Visita",
                column: "IdGuia",
                principalTable: "Visitante",
                principalColumn: "DNI",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visita_Museo_IdMuseo",
                table: "Visita");

            migrationBuilder.DropForeignKey(
                name: "FK_Visitante_Visita_CVisitaID",
                table: "Visitante");

            migrationBuilder.DropTable(
                name: "Obra");

            migrationBuilder.DropTable(
                name: "Plano");

            migrationBuilder.DropTable(
                name: "Turno");

            migrationBuilder.DropTable(
                name: "Artista");

            migrationBuilder.DropTable(
                name: "Exposicion");

            migrationBuilder.DropTable(
                name: "Sala");

            migrationBuilder.DropTable(
                name: "Museo");

            migrationBuilder.DropTable(
                name: "Visita");

            migrationBuilder.DropTable(
                name: "Visitante");
        }
    }
}
