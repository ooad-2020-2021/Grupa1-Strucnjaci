using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace SpaceCat.Migrations
{
    public partial class PrvaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anketa",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(nullable: false),
                    mackeKojeSuUcestvovale = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anketa", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Destinacija",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Paket = table.Column<int>(nullable: false),
                    Naziv = table.Column<string>(nullable: false),
                    Slika = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinacija", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Faq",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Pitanje = table.Column<string>(nullable: false),
                    Odgovor = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faq", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Novost",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Naslov = table.Column<string>(nullable: false),
                    Text = table.Column<string>(nullable: false),
                    VrijemeObjave = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novost", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Macka",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    KorisnickoIme = table.Column<string>(nullable: false),
                    Lozinka = table.Column<string>(nullable: false),
                    ImeVlasnika = table.Column<string>(nullable: false),
                    ImeMacke = table.Column<string>(nullable: false),
                    Drzava = table.Column<string>(nullable: false),
                    Pol = table.Column<int>(nullable: false),
                    DobMacke = table.Column<long>(nullable: false),
                    ZdravaMacka = table.Column<bool>(nullable: false),
                    Slika = table.Column<string>(nullable: false),
                    Paket = table.Column<int>(nullable: false),
                    Odabrana = table.Column<bool>(nullable: false),
                    OdabranaRanije = table.Column<bool>(nullable: false),
                    VjerovatnocaOdabira = table.Column<double>(nullable: false),
                    Kompetentna = table.Column<bool>(nullable: false),
                    DestinacijaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Macka", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Macka_Destinacija_DestinacijaID",
                        column: x => x.DestinacijaID,
                        principalTable: "Destinacija",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Putovanje",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    VrijemePolaska = table.Column<DateTime>(nullable: true),
                    DestinacijaID = table.Column<int>(nullable: true),
                    KrajPutovanja = table.Column<DateTime>(nullable: true),
                    mackeZaPutovanje = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Putovanje", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Putovanje_Destinacija_DestinacijaID",
                        column: x => x.DestinacijaID,
                        principalTable: "Destinacija",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Komentar",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NovostID = table.Column<int>(nullable: false),
                    MackaID = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: false),
                    VrijemeObjave = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Komentar_Macka_MackaID",
                        column: x => x.MackaID,
                        principalTable: "Macka",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Komentar_Novost_NovostID",
                        column: x => x.NovostID,
                        principalTable: "Novost",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Utisak",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MackaID = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: false),
                    Ocjena = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utisak", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Utisak_Macka_MackaID",
                        column: x => x.MackaID,
                        principalTable: "Macka",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Komentar_MackaID",
                table: "Komentar",
                column: "MackaID");

            migrationBuilder.CreateIndex(
                name: "IX_Komentar_NovostID",
                table: "Komentar",
                column: "NovostID");

            migrationBuilder.CreateIndex(
                name: "IX_Macka_DestinacijaID",
                table: "Macka",
                column: "DestinacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Putovanje_DestinacijaID",
                table: "Putovanje",
                column: "DestinacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Utisak_MackaID",
                table: "Utisak",
                column: "MackaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anketa");

            migrationBuilder.DropTable(
                name: "Faq");

            migrationBuilder.DropTable(
                name: "Komentar");

            migrationBuilder.DropTable(
                name: "Putovanje");

            migrationBuilder.DropTable(
                name: "Utisak");

            migrationBuilder.DropTable(
                name: "Novost");

            migrationBuilder.DropTable(
                name: "Macka");

            migrationBuilder.DropTable(
                name: "Destinacija");
        }
    }
}
