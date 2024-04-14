using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Leia a velocidade máxima permitida em uma avenida e a velocidade com que o motorista
                estava dirigindo nela. Se o motorista estiver dentro do limite de velocidade, imprima a
                mensagem “Motorista respeitou a lei”. Se o motorista tiver ultrapassado a velocidade
                máxima permitida, calcule e imprima o valor da multa a ser cobrada, sabendo que os
                valores a serem cobrados são os seguintes:
                • 50 reais se o motorista ultrapassar em até 10km/h a velocidade permitida (ex: se a
                velocidade máxima for 50km/h e o motorista estiver a 60km/h ou a 56km/h);
                • 100 reais, se o motorista ultrapassar de 11km/h a 30km/h a velocidade permitida;
                • 200 reais, se estiver acima de 30km/h da velocidade permitida.*/


            Console.WriteLine("Digite o valor da velocidade Permitida na via:");
            int velmax = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da velocidade do seu veiculo:");
           
            int velveiculo = int.Parse(Console.ReadLine());

            if (velveiculo <= velmax) { Console.WriteLine("Motorista respeitou a lei"); }
            else if (velveiculo > velmax) {
                Console.WriteLine("Voce ganhou uma Multa!");

                if (velveiculo <= (velmax + 10))
                {
                    int multa = 50;
                    Console.WriteLine("O valor da Multa e de:{0} Reais ", multa);
                }
                else if ((velveiculo <= velmax + 11) && (velveiculo <= velmax + 30))
                {
                    int multa = 100;
                    Console.WriteLine("O valor da Multa e de:{0} Reais ", multa);
                }

                else if ( velveiculo > velmax + 30) {
                    int multa = 200;
                    Console.WriteLine("O valor da Multa e de:{0} Reais ", multa);
                }
            
                else { Console.WriteLine("Comando invalido:"); }
                
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}


    
    

