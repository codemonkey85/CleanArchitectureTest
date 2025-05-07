using CleanArchitectureTest.UseCases.ToDos;
using CleanArchitectureTest.UseCases.ToDos.List;

namespace CleanArchitectureTest.Web.ToDos;

public class List(IMediator _mediator) : EndpointWithoutRequest<ToDosListResponse>
{
  public override void Configure()
  {
    Get("/ToDos");
    AllowAnonymous();
  }

  public override async Task HandleAsync(CancellationToken cancellationToken) 
  {
    Result<IEnumerable<ToDoDTO>> result = await _mediator.Send(new ListToDosQuery(), cancellationToken);
    if (result.IsSuccess)
    {
      Response = new ToDosListResponse
      {
        ToDos = result.Value.Select(t => new ToDoRecord(t.Id, t.Title, t.IsCompleted)).ToList()
      };
    }
  }
}
