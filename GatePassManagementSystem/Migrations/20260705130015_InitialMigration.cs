using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GatePassManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblAdminAccessDetails",
                columns: table => new
                {
                    TblId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(40)", nullable: false),
                    LogINdate = table.Column<DateTime>(type: "date", nullable: false),
                    LogINtime = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAdminAccessDetails", x => x.TblId);
                });

            migrationBuilder.CreateTable(
                name: "TblAdminUserDetails",
                columns: table => new
                {
                    TblId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "varchar(10)", nullable: false),
                    Name = table.Column<string>(type: "varchar(40)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAdminUserDetails", x => x.TblId);
                });

            migrationBuilder.CreateTable(
                name: "TblAllApprovedRequests",
                columns: table => new
                {
                    TblId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EPF = table.Column<int>(type: "int", nullable: false),
                    EmployeeName = table.Column<string>(type: "varchar(40)", nullable: false),
                    DPM = table.Column<string>(type: "varchar(20)", nullable: false),
                    Reason = table.Column<string>(type: "varchar(100)", nullable: false),
                    VehicleNo = table.Column<string>(type: "varchar(30)", nullable: false),
                    OutTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserRoleType = table.Column<string>(type: "varchar(15)", nullable: false),
                    ApprovedPerson = table.Column<string>(type: "varchar(40)", nullable: false),
                    RequestCreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestApprovedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAllApprovedRequests", x => x.TblId);
                });

            migrationBuilder.CreateTable(
                name: "TblAllFinalDetailsOfApprovedRequests",
                columns: table => new
                {
                    TblId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EPF = table.Column<int>(type: "int", nullable: false),
                    EmployeeName = table.Column<string>(type: "varchar(40)", nullable: false),
                    DPM = table.Column<string>(type: "varchar(20)", nullable: false),
                    Reason = table.Column<string>(type: "varchar(100)", nullable: false),
                    VehicleNo = table.Column<string>(type: "varchar(30)", nullable: false),
                    OutTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserRoleType = table.Column<string>(type: "varchar(15)", nullable: false),
                    ApprovedPerson = table.Column<string>(type: "varchar(40)", nullable: false),
                    CheckBy = table.Column<string>(type: "varchar(40)", nullable: false),
                    RequestCreatedDate = table.Column<DateTime>(type: "date", nullable: false),
                    ActualOutTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualInTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestApprovedDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAllFinalDetailsOfApprovedRequests", x => x.TblId);
                });

            migrationBuilder.CreateTable(
                name: "TblAllPendingRequests",
                columns: table => new
                {
                    TblId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EPF = table.Column<int>(type: "int", nullable: false),
                    EmployeeName = table.Column<string>(type: "varchar(40)", nullable: false),
                    EmployeeRole = table.Column<string>(type: "varchar(20)", nullable: false),
                    DPM = table.Column<string>(type: "varchar(20)", nullable: false),
                    Reason = table.Column<string>(type: "varchar(100)", nullable: false),
                    VehicleNo = table.Column<string>(type: "varchar(30)", nullable: false),
                    OutTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserRoleType = table.Column<string>(type: "varchar(15)", nullable: false),
                    RequestCreatedDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAllPendingRequests", x => x.TblId);
                });

            migrationBuilder.CreateTable(
                name: "TblAllRejectedRequests",
                columns: table => new
                {
                    TblId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EPF = table.Column<int>(type: "int", nullable: false),
                    EmployeeName = table.Column<string>(type: "varchar(40)", nullable: false),
                    EmployeeRole = table.Column<string>(type: "varchar(20)", nullable: false),
                    DPM = table.Column<string>(type: "varchar(20)", nullable: false),
                    Reason = table.Column<string>(type: "varchar(100)", nullable: false),
                    VehicleNo = table.Column<string>(type: "varchar(30)", nullable: false),
                    OutTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserRoleType = table.Column<string>(type: "varchar(15)", nullable: false),
                    RejectedPerson = table.Column<string>(type: "varchar(40)", nullable: false),
                    RequestCreatedDate = table.Column<DateTime>(type: "date", nullable: false),
                    RequestRejectedDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAllRejectedRequests", x => x.TblId);
                });

            migrationBuilder.CreateTable(
                name: "TblUserAccountDetails",
                columns: table => new
                {
                    TblId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeePhoto = table.Column<byte[]>(type: "VARBINARY(MAX)", nullable: false),
                    EmployeeName = table.Column<string>(type: "varchar(40)", nullable: false),
                    Username = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "varchar(10)", nullable: false),
                    UserRole = table.Column<string>(type: "varchar(20)", nullable: false),
                    ReportingSupervisor = table.Column<string>(type: "varchar(40)", nullable: false),
                    ReportingManager = table.Column<string>(type: "varchar(40)", nullable: false),
                    DPM = table.Column<string>(type: "varchar(20)", nullable: false),
                    UserRoleType = table.Column<string>(type: "varchar(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUserAccountDetails", x => x.TblId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblAdminAccessDetails");

            migrationBuilder.DropTable(
                name: "TblAdminUserDetails");

            migrationBuilder.DropTable(
                name: "TblAllApprovedRequests");

            migrationBuilder.DropTable(
                name: "TblAllFinalDetailsOfApprovedRequests");

            migrationBuilder.DropTable(
                name: "TblAllPendingRequests");

            migrationBuilder.DropTable(
                name: "TblAllRejectedRequests");

            migrationBuilder.DropTable(
                name: "TblUserAccountDetails");
        }
    }
}
