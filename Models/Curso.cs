using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Explorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AddAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
    }
}