using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo que leia 2 números inteiros e faça sua adição. Se o resultado for maior
        ou igual a 10, some 5 a este número. Caso contrário some 7 a ele. Imprima o resultado final.*/
               
                /*Entrada de dados*/
            Console.WriteLine("Digite dois numeros inteiros:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            /*Processamento*/

            int soma = (n1 + n2);

            if (soma >= 10)
            { int tt = (soma + 5);
                Console.WriteLine("O valor total e de: " + tt);
            }
            else {
                int tt = (soma + 7);
                Console.WriteLine("O valor total e de: " + tt);
            }
            Console.ReadKey();
        }
    }
}
