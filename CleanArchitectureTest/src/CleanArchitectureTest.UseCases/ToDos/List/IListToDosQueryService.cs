namespace CleanArchitectureTest.UseCases.ToDos.List;

public interface IListToDosQueryService
{
  /// <summary>
  /// Represents a service that will actually fetch the necessary data
  /// Typically implemented in Infrastructure
  /// </summary>
  Task<IEnumerable<ToDoDTO>> ListAsync();
}
