namespace CleanArchitectureTest.UseCases.ToDos.Get;

public record ListIncompleteToDosQuery : IQuery<Result<IEnumerable<ToDoDTO>>>;
