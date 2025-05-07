
namespace CleanArchitectureTest.UseCases.ToDos.List;

public class ListToDosHandler(IListToDosQueryService _query)
  : IQueryHandler<ListToDosQuery, Result<IEnumerable<ToDoDTO>>>
{
  public async Task<Result<IEnumerable<ToDoDTO>>> Handle(ListToDosQuery request, CancellationToken cancellationToken)
  {
    var result = await _query.ListAsync();

    return Result.Success(result);
  }
}
