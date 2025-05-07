namespace CleanArchitectureTest.Core.ToDoAggregate.Specifications;

public class ToDoByIdSpec : Specification<ToDo>
{
  public ToDoByIdSpec(int toDoId) =>
    Query
        .Where(toDo => toDo.Id == toDoId);
}
