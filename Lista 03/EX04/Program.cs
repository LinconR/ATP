using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um algoritmo que calcule o fatorial de um número. O fatorial de um número n é
          representado por n! e é calculado como apresentado abaixo:*/




            string resp;

            do {
                Console.WriteLine("Digite um numero para calcularmos seu fatorial:");
                int num = int.Parse(Console.ReadLine());
           

                if (num > 0)
            {
            
                long fatorial = 1;

                for (int i = 1; i <= num; i++)
                {
                fatorial *= i;
                Console.WriteLine("O fatorial de " + num + " é: " + fatorial);  }
            }
        
    
            else if (num == 0 ) 
            { Console.WriteLine("o Fatorial e: 1 "); }


            else { Console.WriteLine("O numero esta incorreto"); }


                Console.WriteLine("Deseja inserir outro Numero? ");
                resp = Console.ReadLine();}


            while ( resp == "sim" || resp == "Sim" );
            }
    }
             

    }
