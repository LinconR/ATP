using System;
using System.Xml.Schema;

namespace EX04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um algoritmo que leia o ano de nascimento de uma pessoa e calcule sua idade,
         considerando o ano atual. Para verificar se já fez aniversário no ano atual pergunte se a
         pessoa já fez aniversário, sendo que ela pode entrar com a informação "S"(sim) ou "N"
         (não). Com isso, é possível ter maior precisão sobre a idade. Verifique também se a pessoa
         já tem idade para conseguir Carteira de Habilitação (18 anos ou mais) e imprima a
         mensagem referente a esta checagem. Imprima a idade da pessoa na tela.*/

            /* ENTRADA DE DADOS*/

            Console.WriteLine("Qual e o Ano do seu nacimento?");
            int ano1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Ano atual:");
            int ano2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Voce ja fez Aniversario esse ano ?");
            string rsp = Console.ReadLine();
           
            if (rsp == "sim") {
                int x = (ano2 - ano1);
                Console.WriteLine("Voce tem " + x + " anos.");
                if (x > 18)
                {
                    Console.WriteLine("Voce tem mais de 18 anos  e tem os requisitos para tirar carteira ");
                }
            }
            else { int x = (ano2 - ano1 );
               int y = x- 1;
                Console.WriteLine("Voce tem " + y + " anos."); 
                
                if (y > 18)
                {
                    Console.WriteLine("Voce tem mais de 18 anos  e tem os requisitos para tirar carteira ");
                }
             }

            Console.ReadKey();

        }
    }
}
