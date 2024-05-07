using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX09
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Digite o valor de L:");
                int L = int.Parse(Console.ReadLine());

                int primeiro = 0;
                int segundo = 1;
                int soma = 0;

                while (primeiro < L)
                {
                    soma += primeiro;
                    int proximo = primeiro + segundo;
                    primeiro = segundo;
                    segundo = proximo;
                }

                Console.WriteLine("A soma de todos os elementos da sequência de Fibonacci menores que " + L + " é: " + soma);
            }
        }


    }


