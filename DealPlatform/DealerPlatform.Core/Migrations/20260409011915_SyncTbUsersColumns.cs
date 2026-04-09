using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DealerPlatform.Core.Migrations
{
    /// <inheritdoc />
    public partial class SyncTbUsersColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "tb_users",
                type: "longtext",
                nullable: false,
                comment: "密码")
            .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "tb_users",
                type: "longtext",
                nullable: false,
                comment: "邮箱")
            .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "tb_users",
                type: "datetime(6)",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP(6)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(name: "password", table: "tb_users");
            migrationBuilder.DropColumn(name: "email", table: "tb_users");
            migrationBuilder.DropColumn(name: "created_at", table: "tb_users");
        }
    }
}
