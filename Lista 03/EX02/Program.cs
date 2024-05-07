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
            // Adaptar o programa acima para que ele calcule o percentual dos valores positivos, negativos
            //e zeros em relação ao total de valores fornecidos//
          
            //Entrada de dados 

            int  positivo = 0, negativo = 0, zero = 0;
            double i = 0;
            string opcao;

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
                else 
                {  //Condição se numero for igual a zero aumenta 1 no zero
                    zero++;

                }
                i++;
                Console.WriteLine("Deseja informar outro numero? (s/n)");
                opcao = Console.ReadLine();

            } while (opcao == "s" || opcao == "S" ); //Enquanto 

          

            Console.WriteLine(" Quantidade de Numeros positivos {0}", positivo); // saida de dados 
            Console.WriteLine(" Quantidade de Numeros Negativos {0}", negativo);
            Console.WriteLine(" Quantidade de Zero {0}", zero);

            //Para calcular a porcentagem
            double perp = positivo/i * 100;
            double pern = negativo/i * 100;  
            double perzero = zero/i * 100;

            //Eibir o resultado 

            Console.WriteLine(" Porcentagem de vezes digitada numeros positivo {0}", perp + "%");
            Console.WriteLine(" Porcentagem de vezes digitada numeros Negativos{0}", pern + "%");
            Console.WriteLine(" Porcentagem de vezes digitada numeros zeros {0}", perzero + "%");

            Console.WriteLine("Fim do Programa:");
            Console.ReadKey();
            
        }
    }
}
