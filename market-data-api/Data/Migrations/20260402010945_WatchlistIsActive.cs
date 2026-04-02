using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_core_api_w_postgres.Data.Migrations
{
    /// <inheritdoc />
    public partial class WatchlistIsActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Watchlists",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Watchlists");
        }
    }
}
