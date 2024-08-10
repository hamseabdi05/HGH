using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace KMU.HisOrder.MVC.Migrations
{
    public partial class v10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "kmu_mental",
                columns: table => new
                {
                    mntid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    inhospid = table.Column<string>(type: "text", nullable: true),
                    healthid = table.Column<string>(type: "text", nullable: true),
                    plancode = table.Column<string>(type: "text", nullable: true),
                    plandes = table.Column<string>(type: "text", nullable: true),
                    createdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    createuser = table.Column<string>(type: "text", nullable: true),
                    modifyuser = table.Column<string>(type: "text", nullable: true),
                    patient_answer = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kmu_mental", x => x.mntid);
                });


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clinic_schedule");

            migrationBuilder.DropTable(
                name: "dhis2_diseases");

            migrationBuilder.DropTable(
                name: "hisorderplan_attr");

            migrationBuilder.DropTable(
                name: "hisordersoa");

            migrationBuilder.DropTable(
                name: "home_physicalsign");

            migrationBuilder.DropTable(
                name: "kmu_attribute");

            migrationBuilder.DropTable(
                name: "kmu_auths");

            migrationBuilder.DropTable(
                name: "kmu_auths_log");

            migrationBuilder.DropTable(
                name: "kmu_chart");

            migrationBuilder.DropTable(
                name: "kmu_chart_log");

            migrationBuilder.DropTable(
                name: "kmu_chart_MergeHistory");

            migrationBuilder.DropTable(
                name: "kmu_coderef");

            migrationBuilder.DropTable(
                name: "kmu_condition");

            migrationBuilder.DropTable(
                name: "kmu_department");

            migrationBuilder.DropTable(
                name: "kmu_icd");

            migrationBuilder.DropTable(
                name: "kmu_medfrequency");

            migrationBuilder.DropTable(
                name: "kmu_medfrequency_ind");

            migrationBuilder.DropTable(
                name: "kmu_medicine");

            migrationBuilder.DropTable(
                name: "kmu_medpathway");

            migrationBuilder.DropTable(
                name: "kmu_mental");

            migrationBuilder.DropTable(
                name: "KMU_MergeHistory");

            migrationBuilder.DropTable(
                name: "kmu_ncd");

            migrationBuilder.DropTable(
                name: "kmu_non_medicine");

            migrationBuilder.DropTable(
                name: "kmu_projects");

            migrationBuilder.DropTable(
                name: "kmu_serialpool");

            migrationBuilder.DropTable(
                name: "kmu_users_log");

            migrationBuilder.DropTable(
                name: "physical_sign");

            migrationBuilder.DropTable(
                name: "registration");

            migrationBuilder.DropTable(
                name: "transaction_call");

            migrationBuilder.DropTable(
                name: "transaction_fee");

            migrationBuilder.DropTable(
                name: "hisorderplan");

            migrationBuilder.DropTable(
                name: "kmu_users");

            migrationBuilder.DropSequence(
                name: "hisorderplan_soa_soaid_seq");
        }
    }
}
