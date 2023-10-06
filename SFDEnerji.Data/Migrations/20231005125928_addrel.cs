using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SFDEnerji.Data.Migrations
{
    /// <inheritdoc />
    public partial class addrel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "MetaPage",
                columns: table => new
                {
                    MetasId = table.Column<int>(type: "int", nullable: false),
                    PagesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetaPage", x => new { x.MetasId, x.PagesId });
                    table.ForeignKey(
                        name: "FK_MetaPage_Metas_MetasId",
                        column: x => x.MetasId,
                        principalTable: "Metas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MetaPage_Pages_PagesId",
                        column: x => x.PagesId,
                        principalTable: "Pages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Metas_ProjectId",
                table: "Metas",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Metas_ServiceId",
                table: "Metas",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_MetaPage_PagesId",
                table: "MetaPage",
                column: "PagesId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Metas_Projects_ProjectId",
                table: "Metas");

            migrationBuilder.DropForeignKey(
                name: "FK_Metas_Services_ServiceId",
                table: "Metas");

            migrationBuilder.DropTable(
                name: "MetaPage");

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
        }
    }
}
