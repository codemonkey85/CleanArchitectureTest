﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitectureTest.Infrastructure.Data.Migrations;

  /// <inheritdoc />
  public partial class AddToDos : Migration
  {
      /// <inheritdoc />
      protected override void Up(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.CreateTable(
              name: "ToDos",
              columns: table => new
              {
                  Id = table.Column<int>(type: "INTEGER", nullable: false)
                      .Annotation("Sqlite:Autoincrement", true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_ToDos", x => x.Id);
              });
      }

      /// <inheritdoc />
      protected override void Down(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.DropTable(
              name: "ToDos");
      }
  }
