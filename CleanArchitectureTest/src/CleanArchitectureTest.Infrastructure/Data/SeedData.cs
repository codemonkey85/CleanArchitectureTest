using CleanArchitectureTest.Core.ContributorAggregate;
using CleanArchitectureTest.Core.ToDoAggregate;

namespace CleanArchitectureTest.Infrastructure.Data;
public static class SeedData
{
  public static readonly Contributor Contributor1 = new("Ardalis");
  public static readonly Contributor Contributor2 = new("Snowfrog");

  public static readonly ToDo ToDo1 = new("ToDo 1");
  public static readonly ToDo ToDo2 = new("ToDo 2", isCompleted: true);

  public static async Task InitializeAsync(AppDbContext dbContext)
  {
    if (await dbContext.Contributors.AnyAsync()) return; // DB has been seeded

    await PopulateTestDataAsync(dbContext);
  }

  public static async Task PopulateTestDataAsync(AppDbContext dbContext)
  {
    dbContext.Contributors.AddRange([Contributor1, Contributor2]);
    dbContext.ToDos.AddRange([ToDo1, ToDo2]);
    await dbContext.SaveChangesAsync();
  }
}
