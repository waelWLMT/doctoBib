using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NomDeparetement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodeDepartement = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Villes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NomVille = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodePostal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Canton = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Borough = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lat = table.Column<float>(type: "real", nullable: false),
                    Lng = table.Column<float>(type: "real", nullable: false),
                    DepartementId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Villes_Departements_DepartementId",
                        column: x => x.DepartementId,
                        principalTable: "Departements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Motifs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desciption = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialiteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motifs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Motifs_Specialites_SpecialiteId",
                        column: x => x.SpecialiteId,
                        principalTable: "Specialites",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Adresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    RueBoulevard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartementId = table.Column<int>(type: "int", nullable: false),
                    VilleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adresses_Departements_DepartementId",
                        column: x => x.DepartementId,
                        principalTable: "Departements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adresses_Villes_VilleId",
                        column: x => x.VilleId,
                        principalTable: "Villes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CryptedPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MailAdress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdresseId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SpecialiteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Adresses_AdresseId",
                        column: x => x.AdresseId,
                        principalTable: "Adresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Users_Specialites_SpecialiteId",
                        column: x => x.SpecialiteId,
                        principalTable: "Specialites",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Heure = table.Column<TimeSpan>(type: "time", nullable: false),
                    Recaputulatif = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remarque = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    PraticienId = table.Column<int>(type: "int", nullable: false),
                    MotifId = table.Column<int>(type: "int", nullable: false),
                    PatientId1 = table.Column<int>(type: "int", nullable: true),
                    PraticienId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointements_Motifs_MotifId",
                        column: x => x.MotifId,
                        principalTable: "Motifs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointements_Users_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointements_Users_PatientId1",
                        column: x => x.PatientId1,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointements_Users_PraticienId",
                        column: x => x.PraticienId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointements_Users_PraticienId1",
                        column: x => x.PraticienId1,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Calendriers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDebut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateFin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HeureDebut = table.Column<TimeSpan>(type: "time", nullable: false),
                    HeureFin = table.Column<TimeSpan>(type: "time", nullable: false),
                    Lundi = table.Column<bool>(type: "bit", nullable: false),
                    Mardi = table.Column<bool>(type: "bit", nullable: false),
                    Mercredi = table.Column<bool>(type: "bit", nullable: false),
                    Jeudi = table.Column<bool>(type: "bit", nullable: false),
                    Vendredi = table.Column<bool>(type: "bit", nullable: false),
                    Samedi = table.Column<bool>(type: "bit", nullable: false),
                    Dimanche = table.Column<bool>(type: "bit", nullable: false),
                    PraticienId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendriers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calendriers_Users_PraticienId",
                        column: x => x.PraticienId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menus_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MenuRole",
                columns: table => new
                {
                    MenusId = table.Column<int>(type: "int", nullable: false),
                    RolesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuRole", x => new { x.MenusId, x.RolesId });
                    table.ForeignKey(
                        name: "FK_MenuRole_Menus_MenusId",
                        column: x => x.MenusId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuRole_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_DepartementId",
                table: "Adresses",
                column: "DepartementId");

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_VilleId",
                table: "Adresses",
                column: "VilleId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointements_MotifId",
                table: "Appointements",
                column: "MotifId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointements_PatientId",
                table: "Appointements",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointements_PatientId1",
                table: "Appointements",
                column: "PatientId1");

            migrationBuilder.CreateIndex(
                name: "IX_Appointements_PraticienId",
                table: "Appointements",
                column: "PraticienId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointements_PraticienId1",
                table: "Appointements",
                column: "PraticienId1");

            migrationBuilder.CreateIndex(
                name: "IX_Calendriers_PraticienId",
                table: "Calendriers",
                column: "PraticienId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuRole_RolesId",
                table: "MenuRole",
                column: "RolesId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_UserId",
                table: "Menus",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Motifs_SpecialiteId",
                table: "Motifs",
                column: "SpecialiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AdresseId",
                table: "Users",
                column: "AdresseId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SpecialiteId",
                table: "Users",
                column: "SpecialiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Villes_DepartementId",
                table: "Villes",
                column: "DepartementId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointements");

            migrationBuilder.DropTable(
                name: "Calendriers");

            migrationBuilder.DropTable(
                name: "MenuRole");

            migrationBuilder.DropTable(
                name: "Motifs");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Adresses");

            migrationBuilder.DropTable(
                name: "Specialites");

            migrationBuilder.DropTable(
                name: "Villes");

            migrationBuilder.DropTable(
                name: "Departements");
        }
    }
}
