namespace CleanArchitectureTest.Core.ToDoAggregate.Specifications;

public class IncompleteToDosSpec : Specification<ToDo>
{
  public IncompleteToDosSpec() =>
    Query
      .Where(toDo => toDo.IsCompleted == false)
      .OrderBy(toDo => toDo.Title);
}
