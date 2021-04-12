using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_byteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente ContaChristian = new ContaCorrente();
            ContaChristian.titular = "Christian";
            Console.WriteLine(ContaChristian.saldo);

            ContaCorrente ContaJoao = new ContaCorrente();
            ContaChristian.titular = "Joao";
            Console.WriteLine(ContaJoao.saldo);

            Console.WriteLine("Saldo do Christian atualmente é: " + ContaChristian.saldo);
            Console.WriteLine("Saldo do João atualmente é: " + ContaJoao.saldo);

            bool resultado = ContaChristian.Sacar(500);
            ContaChristian.Depositar(500);
            Console.WriteLine(ContaChristian.saldo);

            bool ContasTransferencisas = ContaChristian.Transferir(300, ContaJoao);
            Console.WriteLine("Resultado da transferencia: " + ContasTransferencisas);

            Console.WriteLine("Saldo do Christian atualmente é: " + ContaChristian.saldo);
            Console.WriteLine("Saldo do João atualmente é: " + ContaJoao.saldo);


            Console.ReadLine();

        }
    }
}
