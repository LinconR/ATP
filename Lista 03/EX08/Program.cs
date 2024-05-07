using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o primeiro número da sequecia: ");
            int num = int.Parse(Console.ReadLine());
            if (num <= 0)
            {
                Console.WriteLine("Por favor, digite um número inteiro positivo maior que zero.");
                return;
            }
            Console.WriteLine("\nOs " + num + " primeiros elementos da sequência de Fibonaccisão: ");
            int primeiroElemento = 0;
            int segundoElemento = 1;
            Console.Write(primeiroElemento + " " + segundoElemento);
            for (int i = 2; i < num; i++)
            {
                int proximoElemento = primeiroElemento + segundoElemento;
                Console.Write(", " + proximoElemento);
                primeiroElemento = segundoElemento;
                segundoElemento = proximoElemento;
            }
            Console.ReadKey();

        }
    }
}
