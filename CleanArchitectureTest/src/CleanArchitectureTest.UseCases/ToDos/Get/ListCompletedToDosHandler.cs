using CleanArchitectureTest.Core.ToDoAggregate;
using CleanArchitectureTest.Core.ToDoAggregate.Specifications;

namespace CleanArchitectureTest.UseCases.ToDos.Get;

public class ListCompletedToDosHandler(IReadRepository<ToDo> _repository)
  : IQueryHandler<ListCompletedToDosQuery, Result<IEnumerable<ToDoDTO>>>
{
  public Task<Result<IEnumerable<ToDoDTO>>> Handle(ListCompletedToDosQuery request, CancellationToken cancellationToken)
  {
    var spec = new CompletedToDosSpec();

    return _repository.ListAsync(spec, cancellationToken)
      .ContinueWith(t =>
      {
        if (t.Result == null) return Result.NotFound();
        var result = t.Result.Select(t => new ToDoDTO(t.Id, t.Title, t.IsCompleted));
        return Result.Success(result);
      }, cancellationToken);
  }
}
