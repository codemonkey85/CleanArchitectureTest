namespace CleanArchitectureTest.UseCases.ToDos.Get;

public record ListCompletedToDosQuery : IQuery<Result<IEnumerable<ToDoDTO>>>;
