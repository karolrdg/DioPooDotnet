using System;
namespace Explorando.Models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal preco, int quantidade)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            Quantidade = quantidade;
        }

        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }
}