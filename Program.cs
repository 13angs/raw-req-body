using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



app.MapGet("/", () => "Hello World!");

List<Todo> todos = new List<Todo>();

app.MapPost("/todo", ([FromBody] object content)=> {
    // var request = Requ
    // todos.Add(todo);
    // Todo? todo = JsonSerializer.Deserialize<Todo>(content.ToString()!);
    Todo? todo = JsonConvert.DeserializeObject<Todo>(content.ToString()!);

    todos.Add(todo!);
    return todos;
});

app.Run();


public class Todo
{
    public int Id { get; set; }
    public string? Name { get; set; }
}
