// See https://aka.ms/new-console-template for more information
using Explorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Naruto";
p1.Sobrenome = "Uzumaki";
p1.Idade = 17;
// p1._nome = "Sasuke"; // Erro de compilação: '_nome' é inacessível devido ao seu nível de proteção


p1.Apresentar();