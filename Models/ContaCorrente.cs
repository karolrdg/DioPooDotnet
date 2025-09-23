using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPoo.Models
{
    public class ContaCorrente
    {

        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }

        private decimal saldo;
        // Metodo
        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente para saque de {valor}.");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {saldo}");
        }
    }
}