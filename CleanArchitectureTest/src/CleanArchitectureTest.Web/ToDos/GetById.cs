using CleanArchitectureTest.UseCases.ToDos.Get;

namespace CleanArchitectureTest.Web.ToDos;
/// <summary>
/// Get a ToDo by integer ID.
/// </summary>
/// <remarks>
/// Takes a positive integer ID and returns a matching ToDo record.
/// </remarks>
public class GetById(IMediator _mediator)
  : Endpoint<GetToDoByIdRequest, ToDoRecord>
{
  public override void Configure()
  {
    Get(GetToDoByIdRequest.Route);
    AllowAnonymous();
  }

  public override async Task HandleAsync(GetToDoByIdRequest request,
    CancellationToken cancellationToken)
  {
    var query = new GetToDoQuery(request.ToDoId);

    var result = await _mediator.Send(query, cancellationToken);

    if (result.Status == ResultStatus.NotFound)
    {
      await SendNotFoundAsync(cancellationToken);
      return;
    }

    if (result.IsSuccess)
    {
      Response = new ToDoRecord(result.Value.Id, result.Value.Title, result.Value.IsCompleted);
    }
  }
}
