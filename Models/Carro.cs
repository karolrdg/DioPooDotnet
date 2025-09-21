
namespace Explorando.Models
{
    public class Carro
    {
        public Carro(int id, string marca, string modelo, int ano, decimal preco)

        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Preco = preco;
        }

        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public decimal Preco { get; set; }
    }
}