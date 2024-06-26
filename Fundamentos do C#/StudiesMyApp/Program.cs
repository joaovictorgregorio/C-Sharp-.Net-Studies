﻿using System;
using System.Data;
using System.Data.SqlTypes;
using System.Globalization;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static System.Console;

namespace StudiesMyApp {
    class Program {
        static void Main(string[] args) {
            Console.Clear();

            /*                                                        STRINGS DETALHES                                                     */

            /* GUID

            var id = Guid.NewGuid();

            Transformando para uma STRING
            id.ToString();

            id = new Guid("ff845e9c-a170-47db-a783-f2d40578e6b8");

            Console.WriteLine(id.ToString().Substring(0, 8));
            */

            /* INTERPOLAÇÃO DE STRINGS

            var price = 10.2;

            var text = "O preço do produto é " + price + " apenas na promoção!";

            var text = string.Format("O preço do produto é {0} apenas na promoção!", price);

            var text = $"O preço do produto é {price} apenas na promoção!";

            Console.WriteLine(text);
            */

            /* COMPARAÇÃO DE STRINGS

            var text = "Testando";

            Console.WriteLine(text.CompareTo("Testando"));
            Console.WriteLine(text.CompareTo("testando"));
            Console.WriteLine(text.Contains("Testando"));
            Console.WriteLine(text.Contains("testando"));
            Console.WriteLine(text.Contains("testando", StringComparison.OrdinalIgnoreCase));
            */

            /*  STARTSWITH / ENDSWITH

            var text = "Este texto é um teste";

            Console.WriteLine(text.StartsWith("Este"));
            Console.WriteLine(text.StartsWith("este"));
            Console.WriteLine(text.StartsWith("livro"));
            Console.WriteLine("--------------------------------");
            Console.WriteLine(text.EndsWith("teste"));
            Console.WriteLine(text.EndsWith("Teste"));
            Console.WriteLine(text.EndsWith("comedia"));
            Console.WriteLine("--------------------------------");
            Console.WriteLine(text.StartsWith("este", StringComparison.OrdinalIgnoreCase));
            */

            /* EQUALS
            var text = "Testando um texto comparação";
            var number = 23;

            Console.WriteLine(text.Equals("Testando um texto comparação"));
            Console.WriteLine(text.Equals("testando um texto comparação"));
            Console.WriteLine(text.Equals("testando um texto comparação", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(number.Equals(24));
            */

            /* ÍNDICES 

            var text = "Este é um texto de teste";

            Mostra à posição de onde se encontra a STRING.
            Console.WriteLine(text.IndexOf("é"));

            Mostra à posição onde apareceu está última STRING.
            Console.WriteLine(text.LastIndexOf("s"));
            */

            /* MÉTODOS ADICIONAIS
            
            var text = "Este texto é um teste";

            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.Insert(11, "aqui "));
            Console.WriteLine(text.Remove(0, 5));
            Console.WriteLine(text.Length);
            */

            /*  MANIPULANDO STRINGS
            var text = "Este texto é um teste";

            Console.WriteLine(text.Replace("e", "a", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("---------------------------");

            var division = text.Split(" ");
            Console.WriteLine(division[0]);
            Console.WriteLine(division[1]);
            Console.WriteLine(division[2]);
            Console.WriteLine(division[3]);
            Console.WriteLine(division[4]);

            Console.WriteLine("---------------------------");

            // var result = text.Substring( 5, 5);
            var result = text.Substring(5, text.LastIndexOf("o"));
            Console.WriteLine(result);
            
            Console.WriteLine("---------------------------");

            var textTrim = " Este é um texto espaçado ";
            Console.WriteLine(textTrim.Trim());
            */

            /* STRINGBUILDER

            var text = new StringBuilder();
            text.Append("Este ");
            text.Append("texto ");
            text.Append("é ");
            text.Append("um ");
            text.Append("teste");

            Console.WriteLine(text.ToString());
            */
            
            /*                                                 DATAS DETALHES                                                            */

            /* INICIANDO COM DATAS

            var data = new DateTime();
            var date = DateTime.Now;
            Console.WriteLine(data);
            Console.WriteLine(date);
            */

            /* OBTENDO VALORES DE DATA

            var data = DateTime.Now;

            Console.WriteLine(data);
            Console.WriteLine($"Ano: {data.Year}");
            Console.WriteLine($"Mês: {data.Month}");
            Console.WriteLine($"Dia: {data.Day}");
            Console.WriteLine($"Horas: {data.Hour}");
            Console.WriteLine($"Minutos: {data.Minute}");
            Console.WriteLine($"Segundos: {data.Second}");
            */

            /* FORMATANDO DATAS

            var data = DateTime.Now;

            var formatada = string.Format("{0:dd/MM/yyyy hh:mm:ss}", data);
            Console.WriteLine(formatada);
            */

            /* PADRÕES DE FORMATAÇÃO

            var data = DateTime.Now;

            string formatadaR = string.Format("{0:r}", data); // Padrão usado em sistemas
            string formatadaS = string.Format("{0:s}", data); // Usado muito no MondoDB, provável em outro banco de dados
            string formatadaU = string.Format("{0:u}", data); // Formato muito visto no JSON

            Console.WriteLine(formatadaR);
            Console.WriteLine(formatadaS);
            Console.WriteLine(formatadaU);
            */

            /* ADICIONANDO VALORES

            var data = DateTime.Now;

            Console.WriteLine(data.AddDays(-8)); // Subtraindo dias
            Console.WriteLine(data.AddDays(26)); // Adicionando dias
            Console.WriteLine(data.AddMonths(2));
            Console.WriteLine(data.AddYears(3));
            */

            /* COMPARANDO DATAS

            var data = DateTime.Now;

            // Não conseguimos comparar a estrutura toda, pois ela pega o objeto de forma completa comparando em milissegundos e frações de segundos, tornando a comparação sempre diferente e nunca igual, usado a propriedade Year para pegar apenas o ano neste caso.
            if(data.Year == DateTime.Now.Year) {
                Console.WriteLine("São iguais!");
            }

            Console.WriteLine(data);
            */

            /* CULTUREINFO

            var br = new CultureInfo("pt-BR");
            var enUs = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atualMaquina = CultureInfo.CurrentCulture; // Identifica a cultura da máquina que está rodando a aplicação.

            Console.WriteLine(DateTime.Now.ToString("D", br));
            Console.WriteLine(DateTime.Now.ToString("D", enUs));
            Console.WriteLine(DateTime.Now.ToString("D", de));
            Console.WriteLine(DateTime.Now.ToString("D", atualMaquina));
            */

            /* TIMEZONE

            // Usar quando sua aplicação for utilizada de forma global.
            var utcDate = DateTime.UtcNow;
            
            Console.WriteLine(DateTime.Now);
            // Retorna data e horário do servidor.
            Console.WriteLine(utcDate);

            // Data e horário conforme o local da máquina.
            Console.WriteLine(utcDate.ToLocalTime());
            Console.WriteLine("+++=====+++=====+++");
            Console.WriteLine("");

            // (UTC+12:00) Auckland, Wellington
            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timezoneAustralia);

            // Data e horário na Australia.
            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
            Console.WriteLine(horaAustralia);
            Console.WriteLine("+++=====+++=====+++");
            Console.WriteLine("");

            // Código para listar todos os fusos horários registrados na biblioteca.
            var timeZones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timeZones) {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                Console.WriteLine("----------------------");
            }
            */
            
            /* TIMESPAN

            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanNanosegundos = new TimeSpan(1);
            Console.WriteLine(timeSpanNanosegundos);

            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 12, 8);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(3, 5, 12, 8, 250);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

            Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(22, 0, 0)));
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Hours);
            */

            /* REVISÃO 

            // Quantos dias tem 1°mês?
            Console.WriteLine(DateTime.DaysInMonth(2024, 2));

            // É fim de semana?
            static bool IsWeekend(DayOfWeek today) {
                return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
            }
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));

            // Horário de verão.
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
            */

            /*                                                 MOEDAS DETALHES                                                            */

            /* TIPOS PARA MOEDAS

            // No caso de moedas sempre priorizar o decimal como tipo de variável, em casos muitos raros usamos outros tipos para performance, com o decimal conseguimos bastante precisão.
            decimal valor = 10.33m;
            WriteLine(valor.ToString(new CultureInfo("en-US")));
            WriteLine(valor.ToString(CultureInfo.CreateSpecificCulture("pt-BR")));
            */

            /* FORMATANDO MOEDAS
            decimal valor = 1044551.443m;
            
            WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("de-DE")));
            WriteLine("=========================================");
            WriteLine(valor.ToString( 
                "C",
                CultureInfo.CreateSpecificCulture("pt-BR")
            )); // Formato para moeda R$ 10,00.
            WriteLine(valor.ToString("G", CultureInfo.CreateSpecificCulture("pt-BR"))); // Formato genérico
            WriteLine(valor.ToString("E04", CultureInfo.CreateSpecificCulture("pt-BR"))); // Formato de número muito extenso
            WriteLine(valor.ToString("F", CultureInfo.CreateSpecificCulture("pt-BR"))); // Melhora a precisão do número
            WriteLine(valor.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR"))); // Mostra o número sem formatação de moeda
            WriteLine(valor.ToString("P", CultureInfo.CreateSpecificCulture("pt-BR"))); // Adiciona a porcentagem no número
            */

            /* MATH
            decimal valor = 10.55m;

            WriteLine(Math.Round(valor)); // Arredonda para o número inteiro mais próximo
            WriteLine(Math.Ceiling(valor)); // Arredonda para o número inteiro acima
            WriteLine(Math.Floor(valor)); // Arredonda para o número inteiro abaixo
            */

            /* REVISÃO
            decimal valor = 10.89m;

            WriteLine(
                string.Format("{0:C}", valor)
            );
            */

            /*                                                       ARRAYS                                                            */

            /* ARRAYS

            var myArray = new int[5] {29, 55, 99, 33, 45};

            Thread.Sleep(200);
            WriteLine(myArray[0]);
            Thread.Sleep(200);
            WriteLine(myArray[1]);
            Thread.Sleep(200);
            WriteLine(myArray[2]);
            Thread.Sleep(200);
            WriteLine(myArray[3]);
            Thread.Sleep(200);
            WriteLine(myArray[4]);

            var myNewArray = new Teste[3];
            myNewArray[0] = new Teste();

            Console.WriteLine(myNewArray[0].Id);
        }

        struct Teste {
            public int Id { get; set; }
        }
        */

        /* PERCORRENDO UM ARRAY

        var myArray = new int[5] { 100, 101, 102, 103, 104 };

        for(var i = 0; i < myArray.Length; i++) {
            Thread.Sleep(200);
            WriteLine(myArray[i] += 1000);
        }
        */

        /*                                                       EXCEPTIONS                                                            */

        // EXCEPTIONS
        var array = new int[3];

        try {
            // for(var i = 0; i < 10; i++) {
            //     // System.IndexOutOfRangeException: Index was outside the bounds of the array.
            //     Console.WriteLine(array[i]);
            // }

            Cadastrar("");
        }
        // Sempre tratar os erros do mais específico para o mais genérico. Caso seja invertido as situações, a própria IDE irá sinalizar como um erro, pois estaremos tratando o erro de forma muito genérica primeiro.
        catch(IndexOutOfRangeException exOne) {
            Console.WriteLine(exOne.InnerException);
            Console.WriteLine(exOne.Message);
            Console.WriteLine("Não encontrei o índice na lista!");
        }
        catch(MinhaException exTwo) {
            Console.WriteLine(exTwo.InnerException);
            Console.WriteLine(exTwo.Message);
            Console.WriteLine(exTwo.QuandoAconteceu);
            Console.WriteLine("Falha ao cadastrar o texto!");
        }
        // É possível usar vários catchs específicos para tratar os erros.
        catch(Exception exThree) {
            Console.WriteLine(exThree.InnerException);
            Console.WriteLine(exThree.Message);
            Console.WriteLine("Algo deu errado!");
        }
        // Sempre irá passar pelo finally, independente do que aconteça. Finally é ótimo para verificar se o arquivo está aberto e confirmar seu fechamento aqui.
        finally {
            Console.WriteLine("Chegou ao fim!");
        }
    }

        private static void Cadastrar(string texto) {
            // Caso a string seja vazia ou nula.
            if(string.IsNullOrEmpty(texto)) {
                throw new MinhaException(DateTime.Now);
            }
        }

        public class MinhaException : Exception {
            public MinhaException(DateTime date) {
                QuandoAconteceu = date;
            }
            public DateTime QuandoAconteceu { get; set; }
        }
    }
}
