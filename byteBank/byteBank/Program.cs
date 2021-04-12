using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(893, 42848327);
            Console.WriteLine(ContaCorrente.TotalContas);

            ContaCorrente contaGabriel = new ContaCorrente(894, 42848399);
            Console.WriteLine(ContaCorrente.TotalContas);


            Console.ReadLine();


        }
    }
}
