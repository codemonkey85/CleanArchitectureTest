using CleanArchitectureTest.UseCases.ToDos;
using CleanArchitectureTest.UseCases.ToDos.Get;

namespace CleanArchitectureTest.Web.ToDos;

public class GetIncomplete(IMediator _mediator)
  : EndpointWithoutRequest<ToDosListResponse>
{
  public override void Configure()
  {
    Get("/ToDos/incomplete");
    AllowAnonymous();
  }
  public override async Task HandleAsync(CancellationToken cancellationToken)
  {
    var query = new ListIncompleteToDosQuery();
    Result<IEnumerable<ToDoDTO>> result = await _mediator.Send(query, cancellationToken);
    if (result.IsSuccess)
    {
      Response = new ToDosListResponse
      {
        ToDos = result.Value.Select(t => new ToDoRecord(t.Id, t.Title, t.IsCompleted)).ToList()
      };
    }
  }
}
