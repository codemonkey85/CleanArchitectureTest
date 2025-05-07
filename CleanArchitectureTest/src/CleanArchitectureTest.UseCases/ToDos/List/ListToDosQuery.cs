namespace CleanArchitectureTest.UseCases.ToDos.List;

public record ListToDosQuery() : IQuery<Result<IEnumerable<ToDoDTO>>>;
