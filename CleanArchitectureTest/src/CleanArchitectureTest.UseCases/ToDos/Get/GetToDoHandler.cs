using CleanArchitectureTest.Core.ToDoAggregate;
using CleanArchitectureTest.Core.ToDoAggregate.Specifications;

namespace CleanArchitectureTest.UseCases.ToDos.Get;

public class GetToDoHandler(IReadRepository<ToDo> _repository)
  : IQueryHandler<GetToDoQuery, Result<ToDoDTO>>
{
  public async Task<Result<ToDoDTO>> Handle(GetToDoQuery request, CancellationToken cancellationToken)
  {
    var spec = new ToDoByIdSpec(request.ToDoId);
    var entity = await _repository.FirstOrDefaultAsync(spec, cancellationToken);
    if (entity == null) return Result.NotFound();

    return new ToDoDTO(entity.Id, entity.Title, entity.IsCompleted);
  }
}
