using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PosgradoAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "sq_formacion_postgraduada");

            migrationBuilder.EnsureSchema(
                name: "sq_personal");

            migrationBuilder.EnsureSchema(
                name: "sq_tesis_titulos");

            migrationBuilder.CreateTable(
                name: "tb_dpersona",
                schema: "sq_personal",
                columns: table => new
                {
                    id_persona = table.Column<string>(type: "text", nullable: false),
                    jefe_autorizado = table.Column<bool>(type: "boolean", nullable: false),
                    id_cargo = table.Column<int>(type: "integer", nullable: true),
                    id_area = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_dpersona", x => x.id_persona);
                });

            migrationBuilder.CreateTable(
                name: "tb_ncategoria_docente",
                schema: "sq_personal",
                columns: table => new
                {
                    id_categoria_docente = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    nombre_categoria_docente = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_ncategoria_docente", x => x.id_categoria_docente);
                });

            migrationBuilder.CreateTable(
                name: "tb_ncategoria_investigativa",
                schema: "sq_personal",
                columns: table => new
                {
                    id_categoria_investigativa = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    nombre_categoria_investigativa = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_ncategoria_investigativa", x => x.id_categoria_investigativa);
                });

            migrationBuilder.CreateTable(
                name: "tb_ncuenta_propia",
                schema: "sq_personal",
                columns: table => new
                {
                    id_cuenta_propia = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    nombre_cuenta_propia = table.Column<string>(type: "text", nullable: false),
                    fecha_registro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_ncuenta_propia", x => x.id_cuenta_propia);
                });

            migrationBuilder.CreateTable(
                name: "tb_nestado_convocatoria",
                schema: "sq_formacion_postgraduada",
                columns: table => new
                {
                    id_estado_convocatoria = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre_estado_convocatoria = table.Column<string>(type: "text", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    fecha_registro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_nestado_convocatoria", x => x.id_estado_convocatoria);
                });

            migrationBuilder.CreateTable(
                name: "tb_nestado_solicitud",
                schema: "sq_formacion_postgraduada",
                columns: table => new
                {
                    id_estado_solicitud = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    nombre_estado_solicitud = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_nestado_solicitud", x => x.id_estado_solicitud);
                });

            migrationBuilder.CreateTable(
                name: "tb_nforma_organizativa",
                schema: "sq_formacion_postgraduada",
                columns: table => new
                {
                    id_forma_organizativa = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre_forma_organizativa = table.Column<string>(type: "text", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_nforma_organizativa", x => x.id_forma_organizativa);
                });

            migrationBuilder.CreateTable(
                name: "tb_ngrado_cientifico",
                schema: "sq_personal",
                columns: table => new
                {
                    id_grado_cientifico = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    nombre_grado_cientifico = table.Column<string>(type: "text", nullable: false),
                    sigla = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_ngrado_cientifico", x => x.id_grado_cientifico);
                });

            migrationBuilder.CreateTable(
                name: "tb_nmodalidad",
                schema: "sq_formacion_postgraduada",
                columns: table => new
                {
                    id_modalidad = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre_modalidad = table.Column<string>(type: "text", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_nmodalidad", x => x.id_modalidad);
                });

            migrationBuilder.CreateTable(
                name: "tb_nperiodicidad",
                schema: "sq_formacion_postgraduada",
                columns: table => new
                {
                    id_periodicidad = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre_periodicidad = table.Column<string>(type: "text", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_nperiodicidad", x => x.id_periodicidad);
                });

            migrationBuilder.CreateTable(
                name: "tb_dparticipante",
                schema: "sq_personal",
                columns: table => new
                {
                    id_persona = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    titulo = table.Column<string>(type: "text", nullable: false),
                    tomo_titulo = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    foto = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    id_categoria_docente = table.Column<int>(type: "integer", nullable: true),
                    telefono = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    correo_electronico = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    centro_trabajo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    folio_titulo = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    telefono_centro_trabajo = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    direccion_centro_trabajo = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    tiempo_en_cargo = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    id_categoria_investigativa = table.Column<int>(type: "integer", nullable: true),
                    id_grado_cientifico = table.Column<int>(type: "integer", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    cuadro = table.Column<bool>(type: "boolean", nullable: false),
                    id_universidad = table.Column<int>(type: "integer", nullable: true),
                    ano_ingreso_educ_superior = table.Column<int>(type: "integer", nullable: true),
                    id_pais_estudios = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    fecha_graduado = table.Column<string>(type: "text", nullable: false),
                    numero_titulo = table.Column<string>(type: "text", nullable: false),
                    id_carrera = table.Column<int>(type: "integer", nullable: true),
                    id_cuenta_propia = table.Column<int>(type: "integer", nullable: true),
                    numero_licencia = table.Column<string>(type: "text", nullable: false),
                    cuenta_propia = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_dparticipante", x => x.id_persona);
                    table.ForeignKey(
                        name: "FK_tb_dparticipante_tb_dpersona_id_persona",
                        column: x => x.id_persona,
                        principalSchema: "sq_personal",
                        principalTable: "tb_dpersona",
                        principalColumn: "id_persona",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_dparticipante_tb_ncategoria_docente_id_categoria_docente",
                        column: x => x.id_categoria_docente,
                        principalSchema: "sq_personal",
                        principalTable: "tb_ncategoria_docente",
                        principalColumn: "id_categoria_docente");
                    table.ForeignKey(
                        name: "FK_tb_dparticipante_tb_ncategoria_investigativa_id_categoria_i~",
                        column: x => x.id_categoria_investigativa,
                        principalSchema: "sq_personal",
                        principalTable: "tb_ncategoria_investigativa",
                        principalColumn: "id_categoria_investigativa");
                    table.ForeignKey(
                        name: "FK_tb_dparticipante_tb_ncuenta_propia_id_cuenta_propia",
                        column: x => x.id_cuenta_propia,
                        principalSchema: "sq_personal",
                        principalTable: "tb_ncuenta_propia",
                        principalColumn: "id_cuenta_propia");
                    table.ForeignKey(
                        name: "FK_tb_dparticipante_tb_ngrado_cientifico_id_grado_cientifico",
                        column: x => x.id_grado_cientifico,
                        principalSchema: "sq_personal",
                        principalTable: "tb_ngrado_cientifico",
                        principalColumn: "id_grado_cientifico");
                });

            migrationBuilder.CreateTable(
                name: "tb_dactividad",
                schema: "sq_formacion_postgraduada",
                columns: table => new
                {
                    id_actividad = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fecha_inicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    horas_totales = table.Column<int>(type: "integer", nullable: true),
                    nombre_actividad = table.Column<string>(type: "text", nullable: false),
                    id_periodicidad = table.Column<int>(type: "integer", nullable: true),
                    id_modalidad = table.Column<int>(type: "integer", nullable: true),
                    id_universidad_colaboradora = table.Column<int>(type: "integer", nullable: true),
                    id_universidad_rectora = table.Column<int>(type: "integer", nullable: true),
                    matricula_total = table.Column<int>(type: "integer", nullable: true),
                    fecha_fin = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    id_forma_organizativa = table.Column<int>(type: "integer", nullable: true),
                    id_programa = table.Column<int>(type: "integer", nullable: true),
                    total_creditos = table.Column<int>(type: "integer", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    id_area = table.Column<string>(type: "text", nullable: false),
                    id_pais = table.Column<int>(type: "integer", nullable: true),
                    area_influencia = table.Column<string>(type: "text", nullable: false),
                    secretaria_creadora = table.Column<string>(type: "text", nullable: false),
                    siglas = table.Column<string>(type: "text", nullable: false),
                    fecha_registro = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_dactividad", x => x.id_actividad);
                    table.ForeignKey(
                        name: "FK_tb_dactividad_tb_nforma_organizativa_id_forma_organizativa",
                        column: x => x.id_forma_organizativa,
                        principalSchema: "sq_formacion_postgraduada",
                        principalTable: "tb_nforma_organizativa",
                        principalColumn: "id_forma_organizativa");
                    table.ForeignKey(
                        name: "FK_tb_dactividad_tb_nmodalidad_id_modalidad",
                        column: x => x.id_modalidad,
                        principalSchema: "sq_formacion_postgraduada",
                        principalTable: "tb_nmodalidad",
                        principalColumn: "id_modalidad");
                    table.ForeignKey(
                        name: "FK_tb_dactividad_tb_nperiodicidad_id_periodicidad",
                        column: x => x.id_periodicidad,
                        principalSchema: "sq_formacion_postgraduada",
                        principalTable: "tb_nperiodicidad",
                        principalColumn: "id_periodicidad");
                });

            migrationBuilder.CreateTable(
                name: "tb_dconvocatoria",
                schema: "sq_formacion_postgraduada",
                columns: table => new
                {
                    id_convocatoria = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fecha_fin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fecha_inicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    id_actividad = table.Column<int>(type: "integer", nullable: false),
                    abierta = table.Column<bool>(type: "boolean", nullable: false),
                    id_estado_convocatoria = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_dconvocatoria", x => x.id_convocatoria);
                    table.ForeignKey(
                        name: "FK_tb_dconvocatoria_tb_dactividad_id_actividad",
                        column: x => x.id_actividad,
                        principalSchema: "sq_formacion_postgraduada",
                        principalTable: "tb_dactividad",
                        principalColumn: "id_actividad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_dconvocatoria_tb_nestado_convocatoria_id_estado_convocat~",
                        column: x => x.id_estado_convocatoria,
                        principalSchema: "sq_formacion_postgraduada",
                        principalTable: "tb_nestado_convocatoria",
                        principalColumn: "id_estado_convocatoria",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_rtomo_folio_num",
                schema: "sq_tesis_titulos",
                columns: table => new
                {
                    id_persona = table.Column<string>(type: "text", nullable: false),
                    id_actividad = table.Column<int>(type: "integer", nullable: false),
                    tomo = table.Column<string>(type: "text", nullable: false),
                    folio = table.Column<string>(type: "text", nullable: false),
                    numero = table.Column<string>(type: "text", nullable: false),
                    profesor = table.Column<bool>(type: "boolean", nullable: false),
                    id_persona_secretaria = table.Column<string>(type: "text", nullable: false),
                    id_persona_profesor = table.Column<string>(type: "text", nullable: false),
                    id_persona_jefe = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_rtomo_folio_num", x => new { x.id_persona, x.id_actividad });
                    table.ForeignKey(
                        name: "FK_tb_rtomo_folio_num_tb_dactividad_id_actividad",
                        column: x => x.id_actividad,
                        principalSchema: "sq_formacion_postgraduada",
                        principalTable: "tb_dactividad",
                        principalColumn: "id_actividad",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_rtomo_folio_num_tb_dpersona_id_persona",
                        column: x => x.id_persona,
                        principalSchema: "sq_personal",
                        principalTable: "tb_dpersona",
                        principalColumn: "id_persona",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_rtomo_folio_num_tb_dpersona_id_persona_jefe",
                        column: x => x.id_persona_jefe,
                        principalSchema: "sq_personal",
                        principalTable: "tb_dpersona",
                        principalColumn: "id_persona",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_rtomo_folio_num_tb_dpersona_id_persona_profesor",
                        column: x => x.id_persona_profesor,
                        principalSchema: "sq_personal",
                        principalTable: "tb_dpersona",
                        principalColumn: "id_persona",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_rtomo_folio_num_tb_dpersona_id_persona_secretaria",
                        column: x => x.id_persona_secretaria,
                        principalSchema: "sq_personal",
                        principalTable: "tb_dpersona",
                        principalColumn: "id_persona",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_dsolicitud",
                schema: "sq_formacion_postgraduada",
                columns: table => new
                {
                    id_solicitud = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_persona = table.Column<string>(type: "character varying(32)", nullable: false),
                    id_convocatoria = table.Column<int>(type: "integer", nullable: true),
                    id_estado_solicitud = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_dsolicitud", x => x.id_solicitud);
                    table.ForeignKey(
                        name: "FK_tb_dsolicitud_tb_dconvocatoria_id_convocatoria",
                        column: x => x.id_convocatoria,
                        principalSchema: "sq_formacion_postgraduada",
                        principalTable: "tb_dconvocatoria",
                        principalColumn: "id_convocatoria");
                    table.ForeignKey(
                        name: "FK_tb_dsolicitud_tb_dparticipante_id_persona",
                        column: x => x.id_persona,
                        principalSchema: "sq_personal",
                        principalTable: "tb_dparticipante",
                        principalColumn: "id_persona",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_dsolicitud_tb_nestado_solicitud_id_estado_solicitud",
                        column: x => x.id_estado_solicitud,
                        principalSchema: "sq_formacion_postgraduada",
                        principalTable: "tb_nestado_solicitud",
                        principalColumn: "id_estado_solicitud");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_dactividad_id_forma_organizativa",
                schema: "sq_formacion_postgraduada",
                table: "tb_dactividad",
                column: "id_forma_organizativa");

            migrationBuilder.CreateIndex(
                name: "IX_tb_dactividad_id_modalidad",
                schema: "sq_formacion_postgraduada",
                table: "tb_dactividad",
                column: "id_modalidad");

            migrationBuilder.CreateIndex(
                name: "IX_tb_dactividad_id_periodicidad",
                schema: "sq_formacion_postgraduada",
                table: "tb_dactividad",
                column: "id_periodicidad");

            migrationBuilder.CreateIndex(
                name: "IX_tb_dconvocatoria_id_actividad",
                schema: "sq_formacion_postgraduada",
                table: "tb_dconvocatoria",
                column: "id_actividad");

            migrationBuilder.CreateIndex(
                name: "IX_tb_dconvocatoria_id_estado_convocatoria",
                schema: "sq_formacion_postgraduada",
                table: "tb_dconvocatoria",
                column: "id_estado_convocatoria");

            migrationBuilder.CreateIndex(
                name: "IX_tb_dparticipante_id_categoria_docente",
                schema: "sq_personal",
                table: "tb_dparticipante",
                column: "id_categoria_docente");

            migrationBuilder.CreateIndex(
                name: "IX_tb_dparticipante_id_categoria_investigativa",
                schema: "sq_personal",
                table: "tb_dparticipante",
                column: "id_categoria_investigativa");

            migrationBuilder.CreateIndex(
                name: "IX_tb_dparticipante_id_cuenta_propia",
                schema: "sq_personal",
                table: "tb_dparticipante",
                column: "id_cuenta_propia");

            migrationBuilder.CreateIndex(
                name: "IX_tb_dparticipante_id_grado_cientifico",
                schema: "sq_personal",
                table: "tb_dparticipante",
                column: "id_grado_cientifico");

            migrationBuilder.CreateIndex(
                name: "IX_tb_dsolicitud_id_convocatoria",
                schema: "sq_formacion_postgraduada",
                table: "tb_dsolicitud",
                column: "id_convocatoria");

            migrationBuilder.CreateIndex(
                name: "IX_tb_dsolicitud_id_estado_solicitud",
                schema: "sq_formacion_postgraduada",
                table: "tb_dsolicitud",
                column: "id_estado_solicitud");

            migrationBuilder.CreateIndex(
                name: "IX_tb_dsolicitud_id_persona",
                schema: "sq_formacion_postgraduada",
                table: "tb_dsolicitud",
                column: "id_persona");

            migrationBuilder.CreateIndex(
                name: "IX_tb_rtomo_folio_num_id_actividad",
                schema: "sq_tesis_titulos",
                table: "tb_rtomo_folio_num",
                column: "id_actividad");

            migrationBuilder.CreateIndex(
                name: "IX_tb_rtomo_folio_num_id_persona_jefe",
                schema: "sq_tesis_titulos",
                table: "tb_rtomo_folio_num",
                column: "id_persona_jefe");

            migrationBuilder.CreateIndex(
                name: "IX_tb_rtomo_folio_num_id_persona_profesor",
                schema: "sq_tesis_titulos",
                table: "tb_rtomo_folio_num",
                column: "id_persona_profesor");

            migrationBuilder.CreateIndex(
                name: "IX_tb_rtomo_folio_num_id_persona_secretaria",
                schema: "sq_tesis_titulos",
                table: "tb_rtomo_folio_num",
                column: "id_persona_secretaria");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_dsolicitud",
                schema: "sq_formacion_postgraduada");

            migrationBuilder.DropTable(
                name: "tb_rtomo_folio_num",
                schema: "sq_tesis_titulos");

            migrationBuilder.DropTable(
                name: "tb_dconvocatoria",
                schema: "sq_formacion_postgraduada");

            migrationBuilder.DropTable(
                name: "tb_dparticipante",
                schema: "sq_personal");

            migrationBuilder.DropTable(
                name: "tb_nestado_solicitud",
                schema: "sq_formacion_postgraduada");

            migrationBuilder.DropTable(
                name: "tb_dactividad",
                schema: "sq_formacion_postgraduada");

            migrationBuilder.DropTable(
                name: "tb_nestado_convocatoria",
                schema: "sq_formacion_postgraduada");

            migrationBuilder.DropTable(
                name: "tb_dpersona",
                schema: "sq_personal");

            migrationBuilder.DropTable(
                name: "tb_ncategoria_docente",
                schema: "sq_personal");

            migrationBuilder.DropTable(
                name: "tb_ncategoria_investigativa",
                schema: "sq_personal");

            migrationBuilder.DropTable(
                name: "tb_ncuenta_propia",
                schema: "sq_personal");

            migrationBuilder.DropTable(
                name: "tb_ngrado_cientifico",
                schema: "sq_personal");

            migrationBuilder.DropTable(
                name: "tb_nforma_organizativa",
                schema: "sq_formacion_postgraduada");

            migrationBuilder.DropTable(
                name: "tb_nmodalidad",
                schema: "sq_formacion_postgraduada");

            migrationBuilder.DropTable(
                name: "tb_nperiodicidad",
                schema: "sq_formacion_postgraduada");
        }
    }
}
