var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



app.MapGet("/", () => "Hello World!");

List<Todo> todos = new List<Todo>();

app.MapPost("/todo", (Todo todo)=> {
    todos.Add(todo);
    return todos;
});

app.Run();


public class Todo
{
    public int Id { get; set; }
    public string? Name { get; set; }
}
