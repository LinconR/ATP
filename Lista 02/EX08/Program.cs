using System;

namespace EX08
{
    internal class Program
    {
        static void Main(string[] args)
        {

                /*Construa um programa que lê uma opção conforme abaixo(usar estrutura SWITCH) e o
                salário atual do funcionário, calcula e exibe o novo salário
                A = aumento de 8% no salário;
                B = aumento de 11% no salário;
                C = aumento fixo no salário
                (de R$ 350,00 se o salário atual for até R$ 1000 e de R$ 200,00 se o salário atual for
                maior que R$ 1000).*/
                
            
               

                Console.WriteLine("Digite um salario do funcionario:");
                int salario = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a opção que vc deseja aunento: A[8%]; B[11%]; C[fixo] ");
                char opcao = char.Parse(Console.ReadLine());    
       

                double novo_salario = 0;

                switch (opcao)
                {
                    case 'A':
                    case 'a':
                        novo_salario = salario * (1.08); // Aumento de 8%
                        break;
                    case 'B':
                    case 'b':
                        novo_salario = salario * (1.11); // Aumento de 11%
                        break;
                    case 'C':
                    case 'c':
                        if (salario <= 1000)
                        {
                            novo_salario = salario + 350;
                        }
                        else
                        {
                            novo_salario = salario + 200;
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        return;
                }

                Console.WriteLine("O novo salário é {0}", novo_salario);
                Console.ReadKey();
            }



        }



    }
    


