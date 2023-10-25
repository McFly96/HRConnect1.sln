using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRConnect1.Server.Migrations
{
    /// <inheritdoc />
    public partial class HRConnect : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Benefits",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benefits", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cittas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cittas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HardSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PosizioniApertes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosizioniApertes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SoftSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attivo = table.Column<bool>(type: "bit", nullable: false),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TitoloStudios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTitolo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitoloStudios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Candidatis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cognome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CittaID = table.Column<int>(type: "int", nullable: false),
                    ContrattoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidatis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidatis_Cittas_CittaID",
                        column: x => x.CittaID,
                        principalTable: "Cittas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sede",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Indirizzo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CittàID = table.Column<int>(type: "int", nullable: false),
                    CittaNavigationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sede", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sede_Cittas_CittaNavigationId",
                        column: x => x.CittaNavigationId,
                        principalTable: "Cittas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CandidatiHardSkill",
                columns: table => new
                {
                    CandidatisId = table.Column<int>(type: "int", nullable: false),
                    HardSkillsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidatiHardSkill", x => new { x.CandidatisId, x.HardSkillsId });
                    table.ForeignKey(
                        name: "FK_CandidatiHardSkill_Candidatis_CandidatisId",
                        column: x => x.CandidatisId,
                        principalTable: "Candidatis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidatiHardSkill_HardSkills_HardSkillsId",
                        column: x => x.HardSkillsId,
                        principalTable: "HardSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CandidatiSoftSkill",
                columns: table => new
                {
                    CandidatisId = table.Column<int>(type: "int", nullable: false),
                    SoftSkillsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidatiSoftSkill", x => new { x.CandidatisId, x.SoftSkillsId });
                    table.ForeignKey(
                        name: "FK_CandidatiSoftSkill_Candidatis_CandidatisId",
                        column: x => x.CandidatisId,
                        principalTable: "Candidatis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidatiSoftSkill_SoftSkills_SoftSkillsId",
                        column: x => x.SoftSkillsId,
                        principalTable: "SoftSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CandidatiTitoloStudio",
                columns: table => new
                {
                    CandidatisId = table.Column<int>(type: "int", nullable: false),
                    TitoloStudiosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidatiTitoloStudio", x => new { x.CandidatisId, x.TitoloStudiosId });
                    table.ForeignKey(
                        name: "FK_CandidatiTitoloStudio_Candidatis_CandidatisId",
                        column: x => x.CandidatisId,
                        principalTable: "Candidatis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidatiTitoloStudio_TitoloStudios_TitoloStudiosId",
                        column: x => x.TitoloStudiosId,
                        principalTable: "TitoloStudios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contrattos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidatiID = table.Column<int>(type: "int", nullable: false),
                    PosizioniAperteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrattos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contrattos_Candidatis_CandidatiID",
                        column: x => x.CandidatiID,
                        principalTable: "Candidatis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contrattos_PosizioniApertes_PosizioniAperteID",
                        column: x => x.PosizioniAperteID,
                        principalTable: "PosizioniApertes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dipendentes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cognome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SedeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dipendentes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Dipendentes_Sede_SedeID",
                        column: x => x.SedeID,
                        principalTable: "Sede",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HRs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cognome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SedeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HRs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HRs_Sede_SedeID",
                        column: x => x.SedeID,
                        principalTable: "Sede",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BenefitDipendente",
                columns: table => new
                {
                    BenefitsID = table.Column<int>(type: "int", nullable: false),
                    DipendentiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenefitDipendente", x => new { x.BenefitsID, x.DipendentiID });
                    table.ForeignKey(
                        name: "FK_BenefitDipendente_Benefits_BenefitsID",
                        column: x => x.BenefitsID,
                        principalTable: "Benefits",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BenefitDipendente_Dipendentes_DipendentiID",
                        column: x => x.DipendentiID,
                        principalTable: "Dipendentes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Colloquios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CandidatiID = table.Column<int>(type: "int", nullable: false),
                    HRID = table.Column<int>(type: "int", nullable: false),
                    PosizioniAperteID = table.Column<int>(type: "int", nullable: false),
                    SedeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colloquios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colloquios_Candidatis_CandidatiID",
                        column: x => x.CandidatiID,
                        principalTable: "Candidatis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Colloquios_HRs_HRID",
                        column: x => x.HRID,
                        principalTable: "HRs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Colloquios_PosizioniApertes_PosizioniAperteID",
                        column: x => x.PosizioniAperteID,
                        principalTable: "PosizioniApertes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Colloquios_Sede_SedeID",
                        column: x => x.SedeID,
                        principalTable: "Sede",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BenefitDipendente_DipendentiID",
                table: "BenefitDipendente",
                column: "DipendentiID");

            migrationBuilder.CreateIndex(
                name: "IX_CandidatiHardSkill_HardSkillsId",
                table: "CandidatiHardSkill",
                column: "HardSkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidatis_CittaID",
                table: "Candidatis",
                column: "CittaID");

            migrationBuilder.CreateIndex(
                name: "IX_CandidatiSoftSkill_SoftSkillsId",
                table: "CandidatiSoftSkill",
                column: "SoftSkillsId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidatiTitoloStudio_TitoloStudiosId",
                table: "CandidatiTitoloStudio",
                column: "TitoloStudiosId");

            migrationBuilder.CreateIndex(
                name: "IX_Colloquios_CandidatiID",
                table: "Colloquios",
                column: "CandidatiID");

            migrationBuilder.CreateIndex(
                name: "IX_Colloquios_HRID",
                table: "Colloquios",
                column: "HRID");

            migrationBuilder.CreateIndex(
                name: "IX_Colloquios_PosizioniAperteID",
                table: "Colloquios",
                column: "PosizioniAperteID");

            migrationBuilder.CreateIndex(
                name: "IX_Colloquios_SedeID",
                table: "Colloquios",
                column: "SedeID");

            migrationBuilder.CreateIndex(
                name: "IX_Contrattos_CandidatiID",
                table: "Contrattos",
                column: "CandidatiID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contrattos_PosizioniAperteID",
                table: "Contrattos",
                column: "PosizioniAperteID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dipendentes_SedeID",
                table: "Dipendentes",
                column: "SedeID");

            migrationBuilder.CreateIndex(
                name: "IX_HRs_SedeID",
                table: "HRs",
                column: "SedeID");

            migrationBuilder.CreateIndex(
                name: "IX_Sede_CittaNavigationId",
                table: "Sede",
                column: "CittaNavigationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BenefitDipendente");

            migrationBuilder.DropTable(
                name: "CandidatiHardSkill");

            migrationBuilder.DropTable(
                name: "CandidatiSoftSkill");

            migrationBuilder.DropTable(
                name: "CandidatiTitoloStudio");

            migrationBuilder.DropTable(
                name: "Colloquios");

            migrationBuilder.DropTable(
                name: "Contrattos");

            migrationBuilder.DropTable(
                name: "Benefits");

            migrationBuilder.DropTable(
                name: "Dipendentes");

            migrationBuilder.DropTable(
                name: "HardSkills");

            migrationBuilder.DropTable(
                name: "SoftSkills");

            migrationBuilder.DropTable(
                name: "TitoloStudios");

            migrationBuilder.DropTable(
                name: "HRs");

            migrationBuilder.DropTable(
                name: "Candidatis");

            migrationBuilder.DropTable(
                name: "PosizioniApertes");

            migrationBuilder.DropTable(
                name: "Sede");

            migrationBuilder.DropTable(
                name: "Cittas");
        }
    }
}
