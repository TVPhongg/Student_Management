using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student_Management.Migrations
{
    public partial class ManagementMigrations2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Score_subject_SubjectId",
                table: "Score");

            migrationBuilder.DropPrimaryKey(
                name: "PK_subject",
                table: "subject");

            migrationBuilder.RenameTable(
                name: "subject",
                newName: "Subject");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subject",
                table: "Subject",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Score_Subject_SubjectId",
                table: "Score",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Score_Subject_SubjectId",
                table: "Score");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subject",
                table: "Subject");

            migrationBuilder.RenameTable(
                name: "Subject",
                newName: "subject");

            migrationBuilder.AddPrimaryKey(
                name: "PK_subject",
                table: "subject",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Score_subject_SubjectId",
                table: "Score",
                column: "SubjectId",
                principalTable: "subject",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
