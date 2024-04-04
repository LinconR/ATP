using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Entrada*/
            Console.WriteLine( "Digite a Base do Retangulo:");
            double base1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Altura do Retangulo:");
            double altura = double.Parse(Console.ReadLine());

            /*Processamento*/
            double perimetro = ((base1 * 2) + (altura * 2));
            double area = (base1 * altura);
            double dig = Math.Sqrt(Math.Pow(base1,2)+ Math.Pow(altura, 2));

            /*Saida*/

            Console.WriteLine(" Area: " + area);
            Console.WriteLine(" Perimetro: " + perimetro);
            Console.WriteLine(" Diagonal: " + dig);



            Console.ReadKey();
        }
    }
}
