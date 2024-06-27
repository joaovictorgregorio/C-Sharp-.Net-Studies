var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Enviar uma informação
app.MapGet("/", () =>
{
    return Results.Ok("Tudo em ordem!");
});

app.MapGet("/name/{nome}", (string nome) =>
{
    return Results.Ok($"Hello {nome}");
});

app.MapPost("/", () =>
{
    return Results.Ok();
});

app.Run();
