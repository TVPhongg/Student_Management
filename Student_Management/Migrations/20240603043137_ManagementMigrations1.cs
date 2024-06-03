using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student_Management.Migrations
{
    public partial class ManagementMigrations1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ccore_Student_StudentId",
                table: "Ccore");

            migrationBuilder.DropForeignKey(
                name: "FK_Ccore_subject_SubjectId",
                table: "Ccore");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ccore",
                table: "Ccore");

            migrationBuilder.RenameTable(
                name: "Ccore",
                newName: "Score");

            migrationBuilder.RenameIndex(
                name: "IX_Ccore_SubjectId",
                table: "Score",
                newName: "IX_Score_SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Score",
                table: "Score",
                columns: new[] { "StudentId", "SubjectId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Score_Student_StudentId",
                table: "Score",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Score_subject_SubjectId",
                table: "Score",
                column: "SubjectId",
                principalTable: "subject",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Score_Student_StudentId",
                table: "Score");

            migrationBuilder.DropForeignKey(
                name: "FK_Score_subject_SubjectId",
                table: "Score");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Score",
                table: "Score");

            migrationBuilder.RenameTable(
                name: "Score",
                newName: "Ccore");

            migrationBuilder.RenameIndex(
                name: "IX_Score_SubjectId",
                table: "Ccore",
                newName: "IX_Ccore_SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ccore",
                table: "Ccore",
                columns: new[] { "StudentId", "SubjectId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Ccore_Student_StudentId",
                table: "Ccore",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ccore_subject_SubjectId",
                table: "Ccore",
                column: "SubjectId",
                principalTable: "subject",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
