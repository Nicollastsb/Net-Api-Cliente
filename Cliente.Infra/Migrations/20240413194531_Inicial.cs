using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cliente.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "BirthDate", "CPF", "Email", "Name", "Observation", "Sex", "Telephone" },
                values: new object[,]
                {
                    { new Guid("6b35c42b-89f6-4a76-b2f6-68aaf9231527"), new DateTime(1993, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "33311122233", "cecilia@teste", "Cecilia", "observação teste", "Feminino", "999998888" },
                    { new Guid("7e5bdf14-3489-4cfd-bfad-16ab05a8e57c"), new DateTime(1993, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "00011122233", "nicollas@teste", "Nicollas", "observação teste", "Masculino", "999998888" },
                    { new Guid("9ebf8d85-532c-4152-87b7-2e8049e521ca"), new DateTime(1993, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "22211122233", "bento@teste", "Bento", "observação teste", "Masculino", "999998888" },
                    { new Guid("f2d932ff-2d45-48b0-86b8-a0fa4621c555"), new DateTime(1993, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "11111122233", "natalia@teste", "Natalia", "observação teste", "Feminino", "999998888" },
                    { new Guid("ff1f357d-0175-4e01-8394-154037b28db0"), new DateTime(1993, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "44411122233", "jose@teste", "Jose", "observação teste", "Masculino", "999998888" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
