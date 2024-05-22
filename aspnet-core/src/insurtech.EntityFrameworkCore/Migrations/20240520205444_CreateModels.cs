using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace insurtech.Migrations
{
    /// <inheritdoc />
    public partial class CreateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "InsuranceUser",
                columns: table => new
                {
                    InsuranceUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceUser", x => x.InsuranceUserId);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_Questions_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    ArticleImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsuranceUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ArticleId);
                    table.ForeignKey(
                        name: "FK_Articles_InsuranceUser_InsuranceUserId",
                        column: x => x.InsuranceUserId,
                        principalTable: "InsuranceUser",
                        principalColumn: "InsuranceUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    InsuranceUserId = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Governorate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.InsuranceUserId);
                    table.ForeignKey(
                        name: "FK_Companies_InsuranceUser_InsuranceUserId",
                        column: x => x.InsuranceUserId,
                        principalTable: "InsuranceUser",
                        principalColumn: "InsuranceUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    InsuranceUserId = table.Column<int>(type: "int", nullable: false),
                    NationalId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.InsuranceUserId);
                    table.ForeignKey(
                        name: "FK_Customers_InsuranceUser_InsuranceUserId",
                        column: x => x.InsuranceUserId,
                        principalTable: "InsuranceUser",
                        principalColumn: "InsuranceUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FAQs",
                columns: table => new
                {
                    FAQId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsuranceUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQs", x => x.FAQId);
                    table.ForeignKey(
                        name: "FK_FAQs_InsuranceUser_InsuranceUserId",
                        column: x => x.InsuranceUserId,
                        principalTable: "InsuranceUser",
                        principalColumn: "InsuranceUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "feedbacks",
                columns: table => new
                {
                    FeedbackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsuranceUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feedbacks", x => x.FeedbackId);
                    table.ForeignKey(
                        name: "FK_feedbacks_InsuranceUser_InsuranceUserId",
                        column: x => x.InsuranceUserId,
                        principalTable: "InsuranceUser",
                        principalColumn: "InsuranceUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsuranceUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationId);
                    table.ForeignKey(
                        name: "FK_Notifications_InsuranceUser_InsuranceUserId",
                        column: x => x.InsuranceUserId,
                        principalTable: "InsuranceUser",
                        principalColumn: "InsuranceUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InsurancePlans",
                columns: table => new
                {
                    InsurancePlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YearlyCoverage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Quotation = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InsuranceUserId = table.Column<int>(type: "int", nullable: false),
                    CompanyInsuranceUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsurancePlans", x => x.InsurancePlanId);
                    table.ForeignKey(
                        name: "FK_InsurancePlans_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InsurancePlans_Companies_CompanyInsuranceUserId",
                        column: x => x.CompanyInsuranceUserId,
                        principalTable: "Companies",
                        principalColumn: "InsuranceUserId");
                    table.ForeignKey(
                        name: "FK_InsurancePlans_InsuranceUser_InsuranceUserId",
                        column: x => x.InsuranceUserId,
                        principalTable: "InsuranceUser",
                        principalColumn: "InsuranceUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthInsurancePlans",
                columns: table => new
                {
                    InsurancePlanId = table.Column<int>(type: "int", nullable: false),
                    MedicalNetwork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClinicsCoverage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HospitalizationAndSurgery = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OpticalCoverage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DentalCoverage = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthInsurancePlans", x => x.InsurancePlanId);
                    table.ForeignKey(
                        name: "FK_HealthInsurancePlans_InsurancePlans_InsurancePlanId",
                        column: x => x.InsurancePlanId,
                        principalTable: "InsurancePlans",
                        principalColumn: "InsurancePlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomeInsurancePlans",
                columns: table => new
                {
                    InsurancePlanId = table.Column<int>(type: "int", nullable: false),
                    WaterDamage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GlassBreakage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NaturalHazard = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AttemptedTheft = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FiresAndExplosion = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeInsurancePlans", x => x.InsurancePlanId);
                    table.ForeignKey(
                        name: "FK_HomeInsurancePlans_InsurancePlans_InsurancePlanId",
                        column: x => x.InsurancePlanId,
                        principalTable: "InsurancePlans",
                        principalColumn: "InsurancePlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MotorInsurancePlans",
                columns: table => new
                {
                    InsurancePlanId = table.Column<int>(type: "int", nullable: false),
                    PersonalAccident = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Theft = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ThirdPartyLiability = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OwnDamage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LegalExpenses = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorInsurancePlans", x => x.InsurancePlanId);
                    table.ForeignKey(
                        name: "FK_MotorInsurancePlans_InsurancePlans_InsurancePlanId",
                        column: x => x.InsurancePlanId,
                        principalTable: "InsurancePlans",
                        principalColumn: "InsurancePlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    RequestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsuranceUserId = table.Column<int>(type: "int", nullable: false),
                    InsurancePlanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.RequestId);
                    table.ForeignKey(
                        name: "FK_Requests_InsurancePlans_InsurancePlanId",
                        column: x => x.InsurancePlanId,
                        principalTable: "InsurancePlans",
                        principalColumn: "InsurancePlanId");
                    table.ForeignKey(
                        name: "FK_Requests_InsuranceUser_InsuranceUserId",
                        column: x => x.InsuranceUserId,
                        principalTable: "InsuranceUser",
                        principalColumn: "InsuranceUserId");
                });

            migrationBuilder.CreateTable(
                name: "RequestQuestions",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    RequestId = table.Column<int>(type: "int", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestQuestions", x => new { x.QuestionId, x.RequestId });
                    table.ForeignKey(
                        name: "FK_RequestQuestions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "QuestionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestQuestions_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
                        principalColumn: "RequestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_InsuranceUserId",
                table: "Articles",
                column: "InsuranceUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FAQs_InsuranceUserId",
                table: "FAQs",
                column: "InsuranceUserId");

            migrationBuilder.CreateIndex(
                name: "IX_feedbacks_InsuranceUserId",
                table: "feedbacks",
                column: "InsuranceUserId");

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePlans_CategoryId",
                table: "InsurancePlans",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePlans_CompanyInsuranceUserId",
                table: "InsurancePlans",
                column: "CompanyInsuranceUserId");

            migrationBuilder.CreateIndex(
                name: "IX_InsurancePlans_InsuranceUserId",
                table: "InsurancePlans",
                column: "InsuranceUserId");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceUser_Email",
                table: "InsuranceUser",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_InsuranceUserId",
                table: "Notifications",
                column: "InsuranceUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_CategoryId",
                table: "Questions",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestQuestions_RequestId",
                table: "RequestQuestions",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_InsurancePlanId",
                table: "Requests",
                column: "InsurancePlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_InsuranceUserId",
                table: "Requests",
                column: "InsuranceUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "FAQs");

            migrationBuilder.DropTable(
                name: "feedbacks");

            migrationBuilder.DropTable(
                name: "HealthInsurancePlans");

            migrationBuilder.DropTable(
                name: "HomeInsurancePlans");

            migrationBuilder.DropTable(
                name: "MotorInsurancePlans");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "RequestQuestions");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "InsurancePlans");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "InsuranceUser");
        }
    }
}
