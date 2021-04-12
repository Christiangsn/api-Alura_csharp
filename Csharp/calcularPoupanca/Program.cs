using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcularPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando Poupança");

            double valorInvestido;

            valorInvestido = 1000;

            valorInvestido = valorInvestido + valorInvestido * 0.0036;
            Console.WriteLine("Apos 1 mês, você tera" + valorInvestido);

            valorInvestido = valorInvestido + valorInvestido * 0.0036;
            Console.WriteLine("Apos 2 mês, você tera" + valorInvestido);

            Console.ReadLine();
        }
    }
}
