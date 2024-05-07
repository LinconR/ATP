using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX05
{
    internal class Program
    {
        static void Main(string[] args)
        
     
            {
                Console.WriteLine("Digite um número inteiro e positivo para calcular E:");
                int N = int.Parse(Console.ReadLine());

                double E = 1.0; // Começa com 1 para incluir o primeiro termo da série
                long fatorial = 1;

                for (int i = 1; i <= N; i++)
                {
                    fatorial *= i; // Calcula o fatorial de i
                    E += 1.0 / fatorial; // Adiciona 1/i! a E
                }

                Console.WriteLine("O valor de E é: " + E);
            Console.ReadKey();  
            }
        }


    }

