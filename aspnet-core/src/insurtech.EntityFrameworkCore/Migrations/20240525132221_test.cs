using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace insurtech.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AbpUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "Password", "SecurityStamp" },
                values: new object[] { "85dc2f79-cbe3-40a8-890f-0789efd16166", new DateTime(2024, 5, 25, 16, 22, 20, 374, DateTimeKind.Local).AddTicks(6286), "AQAAAAIAAYagAAAAEMwqEx0Vq3/BFRcEF3zAq/GElK5Qcl12+aLQYVusYHJfL9RWdC8CW2g8VVPMB6PbVA==", "28834a49-6f35-48e6-bcc7-0188e3e1eccb" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AbpUsers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "ConcurrencyStamp", "CreationTime", "Password", "SecurityStamp" },
                values: new object[] { "39b13379-249e-4ca6-8bb6-4d21eb8ff67b", new DateTime(2024, 5, 23, 19, 3, 9, 948, DateTimeKind.Local).AddTicks(2343), "AQAAAAIAAYagAAAAED5RVmxQbjC4IkJJ5z+parDUG+KJA8EhyvFp2ufuvI+9FaW533BY/eTvXuoQpl56IA==", "da8f1b2c-2f45-4709-bcc9-be5f05e7bb39" });
        }
    }
}
