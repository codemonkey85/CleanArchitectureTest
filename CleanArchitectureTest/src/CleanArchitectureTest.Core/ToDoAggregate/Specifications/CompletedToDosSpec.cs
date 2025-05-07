namespace CleanArchitectureTest.Core.ToDoAggregate.Specifications;

public class CompletedToDosSpec : Specification<ToDo>
{
  public CompletedToDosSpec() =>
    Query
      .Where(toDo => toDo.IsCompleted)
      .OrderBy(toDo => toDo.Title);
}
