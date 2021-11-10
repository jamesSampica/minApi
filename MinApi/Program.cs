var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (HttpContext context) => {
        context.Response.ContentType = "text/html";
        return $"<body>{DummyDataService.People} <form><input type='submit' /></form></body>";
    });

app.MapGet("/person/{id}", (int id, HttpContext context) => {
    context.Response.ContentType = "application/json";
    return DummyDataService.People.FirstOrDefault(p => p.id == id);
});

app.MapPost("/", () => Results.Redirect("/"));

app.Run();


public static class DummyDataService
{
    public static List<Person> People => new List<Person>{
        new Person(1, "Jim", 33),
        new Person(2, "John", 30),
        new Person(3, "Sarah", 32)
    };
}

public record Person(int id, string Name, int Age);