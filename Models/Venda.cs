using System;
namespace Explorando.Models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal preco, int quantidade, string tamanho, DateTime dataVenda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            Quantidade = quantidade;
            Tamanho = tamanho;
            DataVenda = dataVenda;
        }

        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }

        public string Tamanho { get; set; }

        public DateTime DataVenda { get; set; }
    }
}