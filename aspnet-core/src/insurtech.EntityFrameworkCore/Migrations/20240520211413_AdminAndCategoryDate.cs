using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace insurtech.Migrations
{
    /// <inheritdoc />
    public partial class AdminAndCategoryDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Health insurance covers medical expenses like doctor visits, hospital stays, and medications. We offer plans for individuals, families, and businesses, including short-term and supplemental options.", "HealthInsurance" },
                    { 2, "Home insurance protects your home and belongings from risks like fire, theft, and natural disasters. Our plans cover repairs, replacements, and living expenses, ensuring peace of mind for homeowners.", "HomeInsurance" },
                    { 3, "Motor insurance covers your vehicle against accidents, theft, and damage. Our policies offer comprehensive protection, including liability, collision, and personal injury coverage, ensuring peace of mind on the road.", "MotorInsurance" }
                });

            migrationBuilder.InsertData(
                table: "InsuranceUser",
                columns: new[] { "InsuranceUserId", "Email", "FirstName", "LastName", "Number", "Password", "Role" },
                values: new object[] { 1, "AsmaaAsh@gmail.com", "Asmaa", "Ash", "01211236779", "2052024", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InsuranceUser",
                keyColumn: "InsuranceUserId",
                keyValue: 1);
        }
    }
}
