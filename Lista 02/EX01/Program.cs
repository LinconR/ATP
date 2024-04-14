using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dado dois números, imprimir somente o maior deles.*/

            /*Entrada de dados*/

            Console.WriteLine("Digite um numero:");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero:");
            double n2 = double.Parse(Console.ReadLine());

            /*Processamento*/

            if (n1 > n2)
            { Console.WriteLine("O Numero maior e:" + n1); }
            else { Console.WriteLine("O numero maior e:" + n2); }
         
        }
    }
}
