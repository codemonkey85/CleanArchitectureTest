using CleanArchitectureTest.UseCases.ToDos;
using CleanArchitectureTest.UseCases.ToDos.List;

namespace CleanArchitectureTest.Infrastructure.Data.Queries;

public class ListToDosQueryService(AppDbContext _db) : IListToDosQueryService
{
  public async Task<IEnumerable<ToDoDTO>> ListAsync()
  {
    var result = await _db.Database.SqlQuery<ToDoDTO>(
      $"""
      SELECT Id, Title, IsCompleted
      FROM ToDos
      """
      ).ToListAsync();

    return result;
  }
}
