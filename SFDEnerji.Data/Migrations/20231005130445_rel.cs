using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SFDEnerji.Data.Migrations
{
    /// <inheritdoc />
    public partial class rel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Metas_Projects_ProjectId",
                table: "Metas");

            migrationBuilder.DropForeignKey(
                name: "FK_Metas_Services_ServiceId",
                table: "Metas");

            migrationBuilder.DropIndex(
                name: "IX_Metas_ProjectId",
                table: "Metas");

            migrationBuilder.DropIndex(
                name: "IX_Metas_ServiceId",
                table: "Metas");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Metas");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Metas");

            migrationBuilder.CreateTable(
                name: "MetaProject",
                columns: table => new
                {
                    MetasId = table.Column<int>(type: "int", nullable: false),
                    ProjectsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetaProject", x => new { x.MetasId, x.ProjectsId });
                    table.ForeignKey(
                        name: "FK_MetaProject_Metas_MetasId",
                        column: x => x.MetasId,
                        principalTable: "Metas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MetaProject_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MetaService",
                columns: table => new
                {
                    MetasId = table.Column<int>(type: "int", nullable: false),
                    ServicesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetaService", x => new { x.MetasId, x.ServicesId });
                    table.ForeignKey(
                        name: "FK_MetaService_Metas_MetasId",
                        column: x => x.MetasId,
                        principalTable: "Metas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MetaService_Services_ServicesId",
                        column: x => x.ServicesId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MetaProject_ProjectsId",
                table: "MetaProject",
                column: "ProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_MetaService_ServicesId",
                table: "MetaService",
                column: "ServicesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MetaProject");

            migrationBuilder.DropTable(
                name: "MetaService");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Metas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Metas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Metas_ProjectId",
                table: "Metas",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Metas_ServiceId",
                table: "Metas",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Metas_Projects_ProjectId",
                table: "Metas",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Metas_Services_ServiceId",
                table: "Metas",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id");
        }
    }
}
