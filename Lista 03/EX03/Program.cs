using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que receba dez números e verifique se eles são divisíveis por 3 e 9 (ao
            mesmo tempo), por 2 e por 5.Caso algum número não seja divisível por nenhum desses
            números mostre a mensagem “Número não é divisível pelos valores”. Apresente também ao
            final a quantidade de números divisíveis por 3 e 9, por 2 e por 5*/

            int n3e9 = 0, n2e5 = 0 , nada =0;
            

     

            for (int i = 1; i < 10; i++) {

                Console.WriteLine($"Digite o {i}° numero: ");
                int numero = int.Parse( Console.ReadLine());

                if (numero % 3 == 0 && numero % 9 == 0 && numero % 2 == 0 && numero % 5 == 0)
                { 
                    n3e9++;
                    n2e5++;
                }
            
             else if (numero % 3 == 0 && numero % 9 == 0) { n3e9++;}

             else if (numero % 2 == 0 && numero % 5 == 0) { n2e5++;}
             else { Console.WriteLine($"o Numero {numero} nao e divisivel pelos valores 3/9 e 2/5.");
                    nada++; }
            }

            Console.WriteLine($"A quantidade de numeros divisiveis por 3 e 9 e: {n3e9}");
            Console.WriteLine($"A quantidade de numeros divisiveis por 2 e 5 e: {n2e5}");
            Console.WriteLine($"A quantidade de numeros divisiveis por nenhum e: {nada}");
            Console.ReadKey();  

        }
    }
}
