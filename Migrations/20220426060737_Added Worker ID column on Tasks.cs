using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Todo_APP.Migrations
{
    public partial class AddedWorkerIDcolumnonTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "WorkerId",
                table: "ToDoTasks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkerId",
                table: "ToDoTasks");
        }
    }
}
