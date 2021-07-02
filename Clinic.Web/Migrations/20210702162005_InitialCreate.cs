using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clinic.Web.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    City_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.City_Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Country_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country_Desc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Country_Id);
                });

            migrationBuilder.CreateTable(
                name: "Discharges",
                columns: table => new
                {
                    Patient_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patient_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patient_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    F_H_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Chief_Complain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doctor_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Room_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    In_Out_Patient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_on_Admit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    time_of_Admit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_of_Discharge = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Time_of_Discharge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Day_Stayed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Advance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Doctor_Charges = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Test_Charges = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Room_Charges = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Medicine_Charges = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Extra_Charges = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Total_Charges = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Patient_Condition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discharges", x => x.Patient_Id);
                });

            migrationBuilder.CreateTable(
                name: "Diseases",
                columns: table => new
                {
                    Disease_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Disease_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doctor_Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diseases", x => x.Disease_Id);
                });

            migrationBuilder.CreateTable(
                name: "DoctorCharges",
                columns: table => new
                {
                    Patient_Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Doctor_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Charge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Specialist = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorCharges", x => x.Patient_Code);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Doctor_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Doctor_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doctor_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialist_Id = table.Column<int>(type: "int", nullable: true),
                    TimeFrom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Charges = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoginId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Doctor_Id);
                });

            migrationBuilder.CreateTable(
                name: "Medicine",
                columns: table => new
                {
                    Medicine_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Medicine_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medicine_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Mfg_Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Exp_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Company_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Batch_No = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicine", x => x.Medicine_Id);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Patient_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patient_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Patient_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    F_H_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complaint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    I_O_Patient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doctor_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_of_Admit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Time_Admit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Test_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Room_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Advance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Patient_Id);
                });

            migrationBuilder.CreateTable(
                name: "RoomCharges",
                columns: table => new
                {
                    Patient_Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Room_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date_on_Room_Given = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time_of_Room_Given = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoomCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomCharges", x => x.Patient_Code);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Room_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Room_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Room_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Charges = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Room_Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialists",
                columns: table => new
                {
                    Specialist_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Specialist_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Special_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialists", x => x.Specialist_Id);
                });

            migrationBuilder.CreateTable(
                name: "SpecialVisitDoctors",
                columns: table => new
                {
                    Doctor_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Doctor_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Doctor_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specialist_Id = table.Column<int>(type: "int", nullable: true),
                    Charges = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialVisitDoctors", x => x.Doctor_Id);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    State_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    State_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.State_Id);
                });

            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    Test_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Test_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Test_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Charges = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.Test_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Discharges");

            migrationBuilder.DropTable(
                name: "Diseases");

            migrationBuilder.DropTable(
                name: "DoctorCharges");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Medicine");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "RoomCharges");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Specialists");

            migrationBuilder.DropTable(
                name: "SpecialVisitDoctors");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Test");
        }
    }
}
