// See https://aka.ms/new-console-template for more information
using Explorando.Models;
Stack<string> pilha = new Stack<string>();
pilha.Push("Azul");
pilha.Push("Verde");
pilha.Push("Vermelho");

foreach (var cor in pilha)
{
    Console.WriteLine(cor);
}
Console.WriteLine($"Removendo cor do topo: {pilha.Pop()}");

pilha.Push("Amarelo");

foreach (var cor in pilha)
{
    Console.WriteLine(cor);
}




// class Program
// {
//     static void Main()
//     {
//         Queue<string> filaBanco = new Queue<string>();
//         int opcao = 0;

//         do
//         {
//             Console.WriteLine("\n===== Banco C# =====");
//             Console.WriteLine("1 - Adicionar cliente à fila");
//             Console.WriteLine("2 - Atender cliente");
//             Console.WriteLine("3 - Mostrar fila");
//             Console.WriteLine("4 - Ver próximo cliente");
//             Console.WriteLine("0 - Sair");
//             Console.Write("Escolha uma opção: ");

//             // Lê a opção digitada
//             int.TryParse(Console.ReadLine(), out opcao);

//             Console.WriteLine();

//             switch (opcao)
//             {
//                 case 1:
//                     Console.Write("Digite o nome do cliente: ");
//                     string nome = Console.ReadLine();
//                     filaBanco.Enqueue(nome);
//                     Console.WriteLine($"✅ Cliente {nome} entrou na fila.");
//                     break;

//                 case 2:
//                     if (filaBanco.Count > 0)
//                     {
//                         string atendido = filaBanco.Dequeue();
//                         Console.WriteLine($"👩‍💼 Cliente atendido: {atendido}");
//                     }
//                     else
//                     {
//                         Console.WriteLine("⚠️ Nenhum cliente na fila!");
//                     }
//                     break;

//                 case 3:
//                     if (filaBanco.Count > 0)
//                     {
//                         Console.WriteLine("📋 Clientes na fila:");
//                         foreach (var cliente in filaBanco)
//                         {
//                             Console.WriteLine(cliente);
//                         }
//                     }
//                     else
//                     {
//                         Console.WriteLine("⚠️ A fila está vazia.");
//                     }
//                     break;

//                 case 4:
//                     if (filaBanco.Count > 0)
//                     {
//                         Console.WriteLine($"👀 Próximo cliente: {filaBanco.Peek()}");
//                     }
//                     else
//                     {
//                         Console.WriteLine("⚠️ Nenhum cliente na fila.");
//                     }
//                     break;

//                 case 0:
//                     Console.WriteLine("🚪 Encerrando o sistema...");
//                     break;

//                 default:
//                     Console.WriteLine("❌ Opção inválida, tente novamente!");
//                     break;
//             }

//         } while (opcao != 0);
//     }

// class Program
// {
//     static void Main()
//     {
//         Queue<string> filaBanco = new Queue<string>();

//         // Clientes chegam
//         filaBanco.Enqueue("João");
//         filaBanco.Enqueue("Maria");
//         filaBanco.Enqueue("Carlos");
//         filaBanco.Enqueue("Ana");

//         Console.WriteLine("Fila inicial de clientes:");
//         foreach (var cliente in filaBanco)
//         {
//             Console.WriteLine(cliente);
//         }

//         Console.WriteLine("\nAtendimento começa...");

//         // Atender primeiro cliente
//         Console.WriteLine($"Chamando: {filaBanco.Dequeue()}");

//         // Mostrar quem é o próximo
//         Console.WriteLine($"Próximo da fila: {filaBanco.Peek()}");

//         // Novo cliente entra na fila
//         filaBanco.Enqueue("Fernanda");

//         Console.WriteLine("\nFila atualizada:");
//         foreach (var cliente in filaBanco)
//         {
//             Console.WriteLine(cliente);
//         }

//         // Quantos clientes ainda faltam
//         Console.WriteLine($"\nClientes restantes na fila: {filaBanco.Count}");
//     }
// }





// Queue<string> fila = new Queue<string>();
// fila.Enqueue("Azul");
// fila.Enqueue("Verde");
// fila.Enqueue("Amarelo");
// fila.Enqueue("Vermelho");
// fila.Enqueue("Laranja");
// fila.Enqueue("Roxo");


// foreach (var item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o primeiro elemento da fila: {fila.Dequeue()}");
// fila.Enqueue("Rosa");

// foreach (var item in fila)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine($"Primeiro elemento da fila: {fila.Peek()}");
// Console.WriteLine($"Quantidade de elementos na fila: {fila.Count}");
























// new ExemploExcecao().Metodo1();


// try
// {
//     Console.Write("Digite um número: ");
//     int numero = int.Parse(Console.ReadLine()!); // pode gerar erro
//     Console.WriteLine($"Número digitado: {numero}");
// }
// catch (FormatException)
// {
//     Console.WriteLine("Erro: você não digitou um número válido!");
// }
// catch (OverflowException)
// {
//     Console.WriteLine("Erro: o número digitado é muito grande ou muito pequeno!");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Erro genérico: {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Programa finalizado.");
// }

// try
// {
//     Console.Write("Digite sua idade: ");
//     int idade = int.Parse(Console.ReadLine()!); // pode dar erro se digitar "abc"
//     Console.WriteLine($"Sua idade é {idade}");
// }
// catch (FormatException)
// {
//     Console.WriteLine("Erro: você digitou um valor que não é número!");
// }




// try
// {
//     string conteudo = File.ReadAllText("clientes.txt");
//     Console.WriteLine(conteudo);
// }
// catch (FileNotFoundException)
// {
//     Console.WriteLine("Arquivo de clientes não encontrado. Criando um novo...");
//     File.WriteAllText("clientes.txt", "ID;Nome;Email"); // Cria arquivo vazio
// }


// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (var linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }

// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine("O arquivo não foi encontrado: " + ex.Message);
//     // Criar o arquivo q nao existe
//     File.WriteAllText("Arquivos/arquivoLeiitura.txt", "Arquivo criado em: " + DateTime.Now);
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine("O diretório não foi encontrado: " + ex.Message);
// }
// catch (Exception ex)
// {
//     Console.WriteLine("Ocorreu um erro: " + ex.Message);
// }

// Console.WriteLine("Hello, World!");
























// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));





















// decimal valorMonetario = 123456;


// Console.WriteLine($"{valorMonetario:C}");











// int numero1 = 10;
// int numero2 = 20;


// int resultado = numero1 + numero2;

// Console.WriteLine(resultado);



















// Pessoa p1 = new Pessoa(nome: "Naruto", sobrenome: "Uzumaki");
// Pessoa p2 = new Pessoa(nome: "Sasuke", sobrenome: "Uchiha");


// Curso curso = new Curso();
// curso.Nome = "Curso de C#";
// curso.Alunos = new List<Pessoa>();

// curso.AddAluno(p1);
// curso.AddAluno(p2);

// curso.ListarAlunos();






























// Pessoa p1 = new Pessoa();
// p1.Nome = "Naruto";
// p1.Sobrenome = "Uzumaki";
// p1.Idade = 17;
// p1.Altura = 1.80;
// // p1._nome = "Sasuke"; // Erro de compilação: '_nome' é inacessível devido ao seu nível de proteção
// // p1._altura = 1.80; // Erro de compilação: '_altura' é inacessível devido ao seu nível de proteção

// p1.Apresentar();