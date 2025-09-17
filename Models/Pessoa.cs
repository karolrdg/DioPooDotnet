using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Explorando.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome; // Atributo privado
        private int _idade; // Atributo privado
        private double _altura; // Atributo privado
        public string Nome
        {
            get => _nome.ToUpper(); // Acessor get

            set
            {

                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); // Propriedade somente leitura (read-only)


        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa.");
                }

                _idade = value;
            }
        }

        public double Altura
        {
            get => _altura;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A altura não pode ser negativa.");
                }

                _altura = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto} | Idade: {Idade} anos | Altura: {Altura}m.");
        }
    }
}