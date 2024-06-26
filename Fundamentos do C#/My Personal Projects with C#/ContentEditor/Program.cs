﻿using System;
using System.Threading;

namespace ContentEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Instruções de uso...");
            Console.WriteLine("-------------------------------");

            Thread.Sleep(300);
            Console.WriteLine("1 - Criar arquivo");
            Thread.Sleep(300);
            Console.WriteLine("2 - Editar arquivo");
            Thread.Sleep(300);
            Console.WriteLine("3 - Abrir arquivo");
            Thread.Sleep(300);
            Console.WriteLine("4 - Deletar arquivo");
            Thread.Sleep(300);
            Console.WriteLine("5 - Sair");
            Thread.Sleep(300);

            Console.WriteLine("-------------------------------");
            Thread.Sleep(300);
            Console.Write("O que deseja fazer? ");
            Thread.Sleep(300);

            ushort option = ushort.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: CreateFile(); break;
                case 2: EditFile(); break;
                case 3: OpenFile(); break;
                case 4: DeleteFile(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }
        static void CreateFile()
        {
            Console.Clear();

            Console.WriteLine("Digite o conteúdo abaixo (aperte ESC para sair)");
            Console.WriteLine("-------------------------------");

            // String iniciando vazia para armazenar o conteúdo que o usuário digitar.
            string text = "";

            // Uma situação exata para usar o do {} while, continuar executando enquanto não aperta a tecla ESC.
            do
            {
                // Significa que o programa irá ler uma linha de entrada do usuário a partir do console e adicioná-la ao final da cadeia de caracteres armazenada na variável text. Basicamente, cada vez que o código é executado, o programa aguardará até que o usuário insira uma linha de texto no console e, em seguida, adicionará essa linha ao final do conteúdo atual da variável text.
                text += Console.ReadLine();
                // Significa que o programa irá adicionar a sequência de nova linha apropriada para o ambiente atual ao final do conteúdo atual da variável text. Isso é útil para inserir uma nova linha no texto armazenado na variável text, para que o texto subsequente seja escrito em uma nova linha quando ele for exibido ou processado.
                text += Environment.NewLine;
            }
            // Console.ReadKey(): Este método da classe Console é usado para ler a próxima tecla pressionada pelo usuário no console. Ele retorna um objeto ConsoleKeyInfo que contém informações sobre a tecla pressionada, incluindo a tecla propriamente dita e se ela foi modificada por teclas modificadoras, como Shift ou Alt.
            // .Key: Esta é uma propriedade do objeto ConsoleKeyInfo que retorna o valor enumerado (enum) que representa a tecla pressionada.
            // ConsoleKey.Escape: Este é um valor enumerado (enum) que representa a tecla "Escape" no teclado.
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.Write("Deseja salvar o arquivo? [sim ou não] ");
            string save = Console.ReadLine().ToLower();

            if (save == "sim")
            {
                SaveFile(text);
            }
            else
            {
                Menu();
            }
        }
        static void EditFile()
        {
            Console.Clear();

            Console.Write("Qual o caminho do arquivo? ");
            string path = Console.ReadLine();

            if (File.Exists(path))
            {
                CreateFile();
            }
            else
            {
                Menu();
            }
        }
        static void OpenFile()
        {
            Console.Clear();

            Console.Write("Qual o caminho do arquivo que deseja abrir? ");

            string path = Console.ReadLine();

            // Using: Aqui, estamos usando uma instrução using, que garante que os recursos sejam liberados de forma adequada após o seu uso. No caso de objetos que implementam a interface IDisposable, como StreamReader, isso garante que o método Dispose() seja chamado, liberando o recurso associado, mesmo se ocorrerem exceções durante o uso do recurso.
            // var file = new StreamReader(path). Aqui, estamos criando uma instância de StreamReader, que é usado para ler texto de um arquivo. Passamos o caminho do arquivo (path) para o construtor do StreamReader para abrir o arquivo especificado para leitura. O StreamReader é atribuído à variável file.
            // string text = file.ReadToEnd(). Aqui, estamos chamando o método ReadToEnd() do objeto StreamReader para ler todo o conteúdo do arquivo até o final e armazená-lo na variável text. Este método lê todos os caracteres restantes no fluxo de entrada.
            // Console.WriteLine(text). Finalmente, estamos imprimindo o conteúdo do arquivo na saída padrão (no caso, o console) usando Console.WriteLine(). Isso exibirá o conteúdo do arquivo lido pelo StreamReader.
            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }
        static void SaveFile(string text)
        {
            Console.Clear();

            Console.Write("Deseja salvar o arquivo em qual caminho? ");

            // Variável para guardar o caminho digitado pelo usuário. 
            var path = Console.ReadLine();

            // O using é uma instrução que é usada para garantir que um recurso seja liberado após o término de seu uso. Ele é frequentemente usado com recursos que implementam a interface IDisposable, como streams, conexões de banco de dados, etc. Ele garante que o recurso seja liberado (chamando o método Dispose()) assim que o bloco de código associado a ele terminar, mesmo se ocorrerem exceções.
            // var file = new StreamWriter(path). Aqui, estamos inicializando um objeto StreamWriter chamado file e associando-o ao arquivo especificado pelo caminho (path). O StreamWriter é usado para escrever texto em arquivos. Este construtor de StreamWriter recebe o caminho do arquivo como argumento.
            // file.Write(text). Dentro do bloco using, estamos chamando o método Write() do StreamWriter para escrever o conteúdo da variável text no arquivo associado. Este método escreve a cadeia de caracteres fornecida no arquivo.
            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Seu arquivo foi salvo em {path}, com sucesso!");
            Console.ReadLine();
            Menu();
        }
        static void DeleteFile()
        {

        }
    }
}
