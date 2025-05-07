namespace CleanArchitectureTest.Web.ToDos;

public class GetIncompleteToDosRequest
{
  public const string Route = "/ToDos/incomplete";
  public static string BuildRoute() => Route;
}
