using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DealerPlatform.Core.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.AlterDatabase()
            //     .Annotation("MySql:CharSet", "utf8mb4");

            // migrationBuilder.CreateTable(
            //     name: "tb_users",
            //     columns: table => new
            //     {
            //         id = table.Column<int>(type: "int", nullable: false)
            //             .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
            //         username = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, comment: "用户名")
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         password = table.Column<string>(type: "longtext", nullable: false, comment: "密码")
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         email = table.Column<string>(type: "longtext", nullable: false, comment: "邮箱")
            //             .Annotation("MySql:CharSet", "utf8mb4"),
            //         created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP(6)")
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_tb_users", x => x.id);
            //     })
            //     .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropTable(
            //     name: "tb_users");
        }
    }
}
