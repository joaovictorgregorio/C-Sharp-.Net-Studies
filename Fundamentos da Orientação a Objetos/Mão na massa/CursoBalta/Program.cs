using CursoBalta.ContextoDeAssinatura;
using CursoBalta.ContextoDeNotificacao;
using CursoBalta.ContextoDoConteudo;
using CursoBalta.ContextoDoConteudo.Enumeradores;

Console.Clear();
Console.WriteLine($"                  ARTIGOS                  ");
Console.WriteLine("");

/*
var artigos = new List<Artigo>();
artigos.Add(new Artigo("Artigo sobre OOP", "orientacao-objetos"));
artigos.Add(new Artigo("Artigo sobre C#", "csharp"));
artigos.Add(new Artigo("Artigo sobre .NET", "dotnet"));

foreach (var artigo in artigos)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"ID: {artigo.Id}");
    Console.WriteLine($"TITULO: {artigo.Titulo}");
    Console.WriteLine($"URL: {artigo.Url}");
    Console.WriteLine("");
}
*/

var cursos = new List<Curso>();
var cursoOOP = new Curso("Fundamentos OOP", "fundamentos-oop");
var cursoCsharp = new Curso("Fundamentos C#", "fundamentos-csharp");
var cursoAspNet = new Curso("Fundamentos ASP.NET", "fundamentos-aspnet");

cursos.Add(cursoOOP);
cursos.Add(cursoCsharp);
cursos.Add(cursoAspNet);



var carreiras = new List<Carreira>();
var carreiraDotnet = new Carreira("Especialista .NET", "especialista-dotnet");
var itemCarreira2 = new ItemCarreira(2, "Aprenda OOP", "", null);
var itemCarreira3 = new ItemCarreira(3, "Aprenda .NET", "", cursoCsharp);
var itemCarreira = new ItemCarreira(1, "Comece por aqui", "", cursoAspNet);


carreiraDotnet.Items.Add(itemCarreira);
carreiraDotnet.Items.Add(itemCarreira2);
carreiraDotnet.Items.Add(itemCarreira3);
carreiras.Add(carreiraDotnet);


foreach (var carreira in carreiras)
{
    Console.WriteLine(carreira.Titulo);
    foreach (var item in carreira.Items)
    {
        Console.WriteLine($"{item.Ordem} - {item.Titulo}");
        Console.WriteLine(item.Curso?.Titulo);
        Console.WriteLine(item.Curso?.Nivel);

        foreach (var notificacao in item.Notificacoes)
        {
            Console.WriteLine(
                $"{notificacao.Propriedade} - {notificacao.Mensagem}");
        }

        var assinaturaPayPal = new AssinaturaPayPal();
        var aluno = new Aluno();
        aluno.CriaAssinatura(assinaturaPayPal);
    }
}