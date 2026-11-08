WebApplicationBuilder build = WebApplication.CreateBuilder(args);

WebApplication app = build.Build();

app.Map("/user", ([AsParameters] Person person) =>
{
    return $"Name: {person.name} and Age: {person.age}";
});

app.Run();

record class Person(string name, int age);