namespace CleanArchitectureTest.UseCases.ToDos.Get;

public record GetToDoQuery(int ToDoId) : IQuery<Result<ToDoDTO>>;
