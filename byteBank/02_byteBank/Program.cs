using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_byteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();
            cliente.Nome = "Christian";
            cliente.CPF = "46734829737";
            cliente.Profissao = "Desenvolvedor Jr.";

            conta.Titular = cliente;



            conta.Saldo = -10;

            Console.WriteLine(conta.Titular.Nome);

            Console.ReadLine();


        }
    }
}
