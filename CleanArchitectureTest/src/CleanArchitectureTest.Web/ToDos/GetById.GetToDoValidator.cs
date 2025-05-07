using FluentValidation;

namespace CleanArchitectureTest.Web.ToDos;
/// <summary>
/// See: https://fast-endpoints.com/docs/validation
/// </summary>
public class GetToDoValidator : Validator<GetToDoByIdRequest>
{
  public GetToDoValidator()
  {
    RuleFor(x => x.ToDoId)
      .GreaterThan(0);
  }
}
