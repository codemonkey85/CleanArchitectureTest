namespace CleanArchitectureTest.Web.ToDos;

public class GetToDoByIdRequest
{
  public const string Route = "/ToDos/{ToDoId:int}";
  public static string BuildRoute(int ToDoId) => Route.Replace("{ToDoId:int}", ToDoId.ToString());

  public int ToDoId { get; set; }
}
