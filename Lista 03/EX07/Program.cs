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
            {
               Console.WriteLine("Digite um número inteiro e positivo:");
                int n = int.Parse(Console.ReadLine());

                double soma = 0;

                Console.WriteLine("Termos gerados:");

                for (int i = 1; i <= n; i++)
                {
                    double termo = 1.0 / i;
                    Console.WriteLine("1/" + i + " = " + termo);
                    soma += termo;
                }

                Console.WriteLine("Valor final de S = " + soma);
            }
        }

    }
}

