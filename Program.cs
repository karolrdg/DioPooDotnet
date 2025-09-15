// See https://aka.ms/new-console-template for more information
using Explorando.Models;

try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeiitura.txt");

    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }

}
catch (FileNotFoundException ex)
{
    Console.WriteLine("O arquivo não foi encontrado: " + ex.Message);
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine("O diretório não foi encontrado: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Ocorreu um erro: " + ex.Message);
}

Console.WriteLine("Hello, World!");






















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