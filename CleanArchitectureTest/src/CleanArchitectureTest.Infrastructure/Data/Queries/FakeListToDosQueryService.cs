using CleanArchitectureTest.UseCases.ToDos;
using CleanArchitectureTest.UseCases.ToDos.List;

namespace CleanArchitectureTest.Infrastructure.Data.Queries;
public class FakeListToDosQueryService : IListToDosQueryService
{
  public Task<IEnumerable<ToDoDTO>> ListAsync()
  {
    IEnumerable<ToDoDTO> result =
        [new ToDoDTO(1, "Fake ToDo 1", false),
        new ToDoDTO(2, "Fake ToDo 2", true)];

    return Task.FromResult(result);
  }
}
