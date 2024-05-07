using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, coletando dados sobre o
            salário e número de filhos de cada habitante. A prefeitura deseja saber:
            a) A média do salário da população;
            b) A média do número de filhos;
            c) O maior salário;
            d) O percentual de pessoas com salário até R$100,00.
            O final da leitura de dados se dará com a entrada de um salário negativo.*/



            double somaSalario = 0;
            int somaFilhos = 0;
            double maiorSalario = 0;
            int countSalarioAte100 = 0;
            int numeroHabitantes = 0;

            while (true)
            {
                Console.WriteLine("Digite o salário do habitante (ou um valor negativo para sair):");
                double salario = double.Parse(Console.ReadLine());

                if (salario < 0)
                    break; // Sai do loop se for inserido um salário negativo

                Console.WriteLine("Digite o número de filhos do habitante:");
                int numFilhos = int.Parse(Console.ReadLine());

                somaSalario += salario;
                somaFilhos += numFilhos;

                if (salario > maiorSalario)
                    maiorSalario = salario;

                if (salario <= 100)
                    countSalarioAte100++;

                numeroHabitantes++;
            }

            if (numeroHabitantes == 0)
            {
                Console.WriteLine("Nenhum habitante registrado.");
                return;
            }

            double mediaSalario = somaSalario / numeroHabitantes;
            double mediaFilhos = (double)somaFilhos / numeroHabitantes;
            double percentualSalarioAte100 = (double)countSalarioAte100 / numeroHabitantes * 100;

            Console.WriteLine("a) A média do salário da população: " + mediaSalario);
            Console.WriteLine("b) A média do número de filhos: " + mediaFilhos);
            Console.WriteLine("c) O maior salário: " + maiorSalario);
            Console.WriteLine("d) O percentual de pessoas com salário até R$100,00: " + percentualSalarioAte100.ToString("0.00") + "%");
        }
    }
}
        


