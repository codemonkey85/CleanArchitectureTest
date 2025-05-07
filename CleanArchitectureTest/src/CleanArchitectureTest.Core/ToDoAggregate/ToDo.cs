namespace CleanArchitectureTest.Core.ToDoAggregate;

public class ToDo(string title, bool isCompleted = false) : EntityBase, IAggregateRoot
{
  public string Title { get; private set; } = Guard.Against.NullOrEmpty(title, nameof(title));

  public bool IsCompleted { get; private set; } = isCompleted;

  public void UpdateTitle(string newTitle)
  {
    Title = Guard.Against.NullOrEmpty(newTitle, nameof(newTitle));
  }

  public void MarkAsCompleted()
  {
    IsCompleted = true;
  }

  public void MarkAsUncompleted()
  {
    IsCompleted = false;
  }
}
