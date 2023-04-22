using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quilometros;
            double mph;
            double conv = 1852;

            Console.WriteLine("valor de milhas");
            mph = double.Parse(Console.ReadLine());

            quilometros = mph * conv;
            Console.WriteLine("valor da conversao {0}", quilometros);
        }
    }
}
