using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitectureTest.Infrastructure.Data.Migrations;

  /// <inheritdoc />
  public partial class UpdateToDos : Migration
  {
      /// <inheritdoc />
      protected override void Up(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.AddColumn<bool>(
              name: "IsCompleted",
              table: "ToDos",
              type: "INTEGER",
              nullable: false,
              defaultValue: false);

          migrationBuilder.AddColumn<string>(
              name: "Title",
              table: "ToDos",
              type: "TEXT",
              maxLength: 100,
              nullable: false,
              defaultValue: "");
      }

      /// <inheritdoc />
      protected override void Down(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.DropColumn(
              name: "IsCompleted",
              table: "ToDos");

          migrationBuilder.DropColumn(
              name: "Title",
              table: "ToDos");
      }
  }
