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
            /*Fazer um programa que leia uma sequência de valores inteiros fornecida pelo usuário em
            uma linha de entrada e conte o número de valores positivos, negativos e zeros.*/


            //Entrada de dados 

            int i = 0, positivo = 0, negativo = 0, zero = 0;
            do // Faça-enquanto
            {
                Console.WriteLine("Digite um Numero:");
                int num = int.Parse(Console.ReadLine());

                if (num > 0) //Condição se numero for maior que zero aumenta 1 no positivo 
                {
                    positivo++;

                }
                else if (num < 0) //Condição se numero for menor  que zero aumenta 1 no negativo
                {
                    negativo++;

                }
                else if (num == 0)
                {  //Condição se numero for igual a zero aumenta 1 no zero
                    zero++;

                }
                Console.WriteLine(" Quantidade de Numeros positivos {0}", positivo); // saida de dados 
                Console.WriteLine(" Quantidade de Numeros Negativos {0}", negativo);
                Console.WriteLine(" Quantidade de Zero {0}", zero);
                i++;



            }
            while (i != 10 ); //Enquanto 
            {
                Console.WriteLine("Fim do Programa:");
                Console.ReadKey();
            }

        }
    

            }
    }

