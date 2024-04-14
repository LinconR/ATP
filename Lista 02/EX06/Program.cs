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
            /*Um hotel com 75 apartamentos deseja fazer uma promoção especial de final de semana,
            concedendo um desconto de 25% na diária. Com isso, espera aumentar sua taxa de
            ocupação de 50% para 80%. Sendo dado o valor normal da diária, calcular e imprimir:
            a) O valor da diária promocional;
            b) O valor total arrecadado com 80% de ocupação e diária promocional;
            c) O valor total arrecadado com 50% de ocupação e diária normal;
            d) A diferença entre esses dois valores*/

            /*ENTRADA DE DADOS */
            Console.WriteLine("Gostaria de entrar com as diarias em promocional ou valor comum?");
            string resp = Console.ReadLine();

            /*PROCESSAMENTO*/
            /*LETRA A */

            if (resp == "promocional")
            {
                Console.WriteLine("Digite o valor da diaria: Promocional");
                double diaria = double.Parse(Console.ReadLine());

                double diariaP = (diaria * 0.75);
                Console.WriteLine("o valor da diaria promocional e de: " + diariaP);
                /*LETRA B*/
                double tt = (60 * diariaP);
                Console.WriteLine("O valor total arrecadado de apartamentos ocupados com diaria promocional e de:" + tt);

                Console.WriteLine("Qual seria o valor da diaria comum?");
                double valor_d_Comum = Double.Parse(Console.ReadLine());
                /*LETRA D */

                double tta = (tt - valor_d_Comum);
                Console.WriteLine("A diferença do lucro de promocional e comum e de: {0}", tta);


                Console.ReadKey();
            }


            else if (resp == "Comum")
            {
                Console.WriteLine("Digite o valor da diaria:");
                double diaria = double.Parse(Console.ReadLine());
                /*LETRA C*/

                double ttp = (37.5 * diaria);
                Console.WriteLine("O valor total arrecadado de apartamentos ocupados com diaria comum e de:" + ttp);

                Console.WriteLine("Qual seria o valor da diaria Promocional?");
                double valor_d_promocional = Double.Parse(Console.ReadLine());
                /*LETRA D */

                double tta = (ttp - valor_d_promocional);
                Console.WriteLine("A diferença do lucro de promocional e comum e de: {0}", tta);


                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Comando invalido");
            }



        }
    }
}
        
    

