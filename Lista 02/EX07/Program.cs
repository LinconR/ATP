using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Faça um programa para calcular e imprimir o valor de Y, dado um valor de X:*/



            /*Entrada de dados*/
            Console.WriteLine("Digite o valor de x:");
            int x1 = int.Parse(Console.ReadLine());

            int y1 = 0;

            if (x1 <= 1) { Console.WriteLine("O valor de x: e 1" );}
            else if (1 < x1 && x1 <= 2) { Console.WriteLine("O valor de y: e 2"); }
            else if (2 < x1 && x1 <= 3) { Console.WriteLine("O valor de y: e {0}", Math.Pow(x1, 2)); }
            else if ( x1 > 3) { Console.WriteLine("O valor de y: e {0}", Math.Pow(x1, 3)); }
            else { Console.WriteLine("Numero invalido!"); }

            Console.ReadKey();  







        }
    }
}
