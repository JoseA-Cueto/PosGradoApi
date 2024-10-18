using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PosgradoAPI.Migrations
{
    /// <inheritdoc />
    public partial class addEnumsAndFkAndList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Professional_GraduateProgram_GraduateProgramId",
                table: "Professional");

            migrationBuilder.AddColumn<int>(
                name: "ProfessorId",
                table: "Thesis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AffiliationWithTheParty",
                table: "Professor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GraduateProgramId",
                table: "Professor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDirectingDoctorate",
                table: "Professor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ReceivedTraining",
                table: "Professor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TypeProfesional",
                table: "Professor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "GraduateProgramId",
                table: "Professional",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AffiliationWithTheParty",
                table: "Professional",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "ReceivedTraining",
                table: "Professional",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Thesis_ProfessorId",
                table: "Thesis",
                column: "ProfessorId");

            migrationBuilder.CreateIndex(
                name: "IX_Professor_GraduateProgramId",
                table: "Professor",
                column: "GraduateProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Professional_GraduateProgram_GraduateProgramId",
                table: "Professional",
                column: "GraduateProgramId",
                principalTable: "GraduateProgram",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Professor_GraduateProgram_GraduateProgramId",
                table: "Professor",
                column: "GraduateProgramId",
                principalTable: "GraduateProgram",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Thesis_Professor_ProfessorId",
                table: "Thesis",
                column: "ProfessorId",
                principalTable: "Professor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Professional_GraduateProgram_GraduateProgramId",
                table: "Professional");

            migrationBuilder.DropForeignKey(
                name: "FK_Professor_GraduateProgram_GraduateProgramId",
                table: "Professor");

            migrationBuilder.DropForeignKey(
                name: "FK_Thesis_Professor_ProfessorId",
                table: "Thesis");

            migrationBuilder.DropIndex(
                name: "IX_Thesis_ProfessorId",
                table: "Thesis");

            migrationBuilder.DropIndex(
                name: "IX_Professor_GraduateProgramId",
                table: "Professor");

            migrationBuilder.DropColumn(
                name: "ProfessorId",
                table: "Thesis");

            migrationBuilder.DropColumn(
                name: "AffiliationWithTheParty",
                table: "Professor");

            migrationBuilder.DropColumn(
                name: "GraduateProgramId",
                table: "Professor");

            migrationBuilder.DropColumn(
                name: "IsDirectingDoctorate",
                table: "Professor");

            migrationBuilder.DropColumn(
                name: "ReceivedTraining",
                table: "Professor");

            migrationBuilder.DropColumn(
                name: "TypeProfesional",
                table: "Professor");

            migrationBuilder.DropColumn(
                name: "AffiliationWithTheParty",
                table: "Professional");

            migrationBuilder.DropColumn(
                name: "ReceivedTraining",
                table: "Professional");

            migrationBuilder.AlterColumn<int>(
                name: "GraduateProgramId",
                table: "Professional",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Professional_GraduateProgram_GraduateProgramId",
                table: "Professional",
                column: "GraduateProgramId",
                principalTable: "GraduateProgram",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
