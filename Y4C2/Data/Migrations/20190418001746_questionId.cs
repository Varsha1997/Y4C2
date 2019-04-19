using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Y4C2.Migrations
{
    public partial class questionId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*
            migrationBuilder.DropColumn(
                name: "ArchiveStatus",
                table: "Account");
                */
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Account",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TakenYogaClass",
                table: "Account",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Account",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LName",
                table: "Account",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FName",
                table: "Account",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Account",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Dob",
                table: "Account",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            /* migrationBuilder.AddColumn<string>(
                 name: "ArchiveStatus",
                 table: "AC",
                 nullable: true);
                 */
            /*
        migrationBuilder.CreateTable(
            name: "Survey",
            columns: table => new
            {
                Id = table.Column<int>(nullable: false)
                    .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                ThemeId = table.Column<int>(nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Survey", x => x.Id);
                table.ForeignKey(
                    name: "FK_Survey_AC_ThemeId",
                    column: x => x.ThemeId,
                    principalTable: "AC",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Restrict);
            });


        migrationBuilder.CreateTable(
            name: "Questions",
            columns: table => new
            {
                Id = table.Column<int>(nullable: false)
                    .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                SurveyId = table.Column<int>(nullable: false),
                Question = table.Column<string>(nullable: true),
                Type = table.Column<string>(nullable: true),
                QNumber = table.Column<int>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Questions", x => x.Id);
                table.ForeignKey(
                    name: "FK_Questions_Survey_SurveyId",
                    column: x => x.SurveyId,
                    principalTable: "Survey",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });


        migrationBuilder.CreateTable(
            name: "Answer",
            columns: table => new
            {
                Id = table.Column<int>(nullable: false)
                    .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                Response = table.Column<string>(nullable: true),
                QuestionId = table.Column<int>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Answer", x => x.Id);
                table.ForeignKey(
                    name: "FK_Answer_Questions_QuestionId",
                    column: x => x.QuestionId,
                    principalTable: "Questions",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });
            */
            migrationBuilder.CreateIndex(
                name: "IX_Answer_QuestionId",
                table: "Answer",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SurveyId",
                table: "Questions",
                column: "SurveyId");

          /*  migrationBuilder.CreateIndex(
                name: "IX_Survey_ThemeId",
                table: "Survey",
                column: "ThemeId"); */
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Survey");

            migrationBuilder.DropColumn(
                name: "ArchiveStatus",
                table: "AC");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Account",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "TakenYogaClass",
                table: "Account",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Account",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LName",
                table: "Account",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FName",
                table: "Account",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Account",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Dob",
                table: "Account",
                nullable: true,
                oldClrType: typeof(DateTime));

           /* migrationBuilder.AddColumn<string>(
                name: "ArchiveStatus",
                table: "Account",
                nullable: true); */
        }
    }
}
