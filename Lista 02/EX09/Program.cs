using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ler um símbolo do teclado;
            • Identificar com a estrutura SWITCH e mostrar as seguintes mensagens, segundo o
            caso:
                        o "SINAL DE MENOR"
            o "SINAL DE MAIOR"
            o "SINAL DE IGUAL"
            o "OUTRO SINAL"*/


            //Entrada de dados//

            Console.WriteLine("Digite um operador matematico; [+];[-];[*];[/];[=];[<];[>]");
            char sinal = char.Parse(Console.ReadLine());

            
            switch (sinal) {
            
            case '+':
                    Console.WriteLine("O sinal e de 'Mais'.");break;
                case '-':
                    Console.WriteLine("O sinal e de 'Menos'."); break;
                case '*':
                    Console.WriteLine("O sinal e de 'Multiplicação'."); break;
                case '/':
                    Console.WriteLine("O sinal e de 'Divisão'."); break;
                case '=':
                    Console.WriteLine("O sinal e de 'Igualdade'."); break;
                case '<':
                    Console.WriteLine("O sinal e de 'Menor'."); break;
                case '>':
                    Console.WriteLine("O sinal e de 'Maior'."); break;

           }
            Console.ReadKey();
        }
    }
}
