using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11
{
    internal class Program
    {
        static void Main(string[] args)
        {
     
                int[] votosCandidatos = new int[4]; // Array para armazenar os votos para cada candidato
                int votosNulos = 0;
                int votosBrancos = 0;

                Console.WriteLine("Digite o código do candidato (ou 0 para encerrar):");

                int codigoVoto = int.Parse(Console.ReadLine());

                while (codigoVoto != 0)
                {
                    switch (codigoVoto)
                    {
                        case 1:
                            votosCandidatos[0]++;
                            break;
                        case 2:
                            votosCandidatos[1]++;
                            break;
                        case 3:
                            votosCandidatos[2]++;
                            break;
                        case 4:
                            votosCandidatos[3]++;
                            break;
                        case 5:
                            votosNulos++;
                            break;
                        case 6:
                            votosBrancos++;
                            break;
                        default:
                            Console.WriteLine("Código inválido!");
                            break;
                    }

                    Console.WriteLine("Digite o código do candidato (ou 0 para encerrar):");
                    codigoVoto = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Total de votos para o candidato 1: " + votosCandidatos[0]);
                Console.WriteLine("Total de votos para o candidato 2: " + votosCandidatos[1]);
                Console.WriteLine("Total de votos para o candidato 3: " + votosCandidatos[2]);
                Console.WriteLine("Total de votos para o candidato 4: " + votosCandidatos[3]);
                Console.WriteLine("Total de votos nulos: " + votosNulos);
                Console.WriteLine("Total de votos em branco: " + votosBrancos);
            }
        }

    }


