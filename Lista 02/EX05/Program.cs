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

            /*aça um algoritmo que, segundo uma nota informada pelo usuário, verifique em qual faixa
a mesma se encaixa e imprima para o usuário a mensagem correspondente conforme a
tabela abaixo:*/


            Console.WriteLine("Digite sua nota:");
            double nota = double.Parse(Console.ReadLine());

            if (nota > 10 ) { Console.WriteLine("Nota Invalida!"); }
            else if (nota >= 8 && nota <= 10) { Console.WriteLine("Otimo!"); }
            else if (nota >= 7 && nota < 8) { Console.WriteLine("Bom"); }
            else if (nota >= 5 && nota < 7) { Console.WriteLine("Regular"); }
            else if  (nota < 5) { Console.WriteLine("Insatisfaório"); }
           else if (nota < 0 ) { Console.WriteLine("Nota invalida!"); }
            else { Console.WriteLine("Repita o Processo."); }
            Console.ReadKey();
        }
    }
}
