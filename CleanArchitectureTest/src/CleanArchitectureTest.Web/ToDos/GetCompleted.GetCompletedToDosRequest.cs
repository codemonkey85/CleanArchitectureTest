namespace CleanArchitectureTest.Web.ToDos;

public class GetCompletedToDosRequest
{
  public const string Route = "/ToDos/completed";
  public static string BuildRoute() => Route;
}
