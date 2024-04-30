using CursoBalta.ContextoDoConteudo;
using CursoBalta.ContextoDoConteudo.Enumeradores;

Console.Clear();

var curso = new Curso();
var carreira = new Carreira();
carreira.Items.Add(new ItemCarreira());
Console.WriteLine(carreira.TotalCursos);
