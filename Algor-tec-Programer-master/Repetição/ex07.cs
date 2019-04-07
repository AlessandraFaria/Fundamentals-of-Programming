using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            double codicli,investipo,invesvalo,rend,investtotal=0,jurostotal=0;

            Console.WriteLine("Digite o cógido do cliente e 0 para sair");
            codicli = Convert.ToDouble(Console.ReadLine());

            while (codicli!=0)
            {
               

                Console.WriteLine("Digite 1-poupança , 2-poupança plus ,3-fundos de renda fixa ");
                investipo = Convert.ToDouble(Console.ReadLine());

                if (investipo<4) {
                    Console.WriteLine("Digitr o valor do investimento");
                    invesvalo = Convert.ToDouble(Console.ReadLine());
                    if (investipo == 1)
                    {
                        rend = investipo * 0.15;
                        investtotal = investtotal + invesvalo;

                        Console.WriteLine("o valor do rendimento é " + rend);
                        jurostotal = jurostotal + rend;
                    }

                    else if (investipo == 2)
                    {
                        rend = investipo * 0.20;
                        investtotal = investtotal + invesvalo;

                        Console.WriteLine("o valor do rendimento é " + rend);
                        jurostotal = jurostotal + rend;
                    }

                    else if (investipo == 3)
                    {
                        rend = investipo * 0.20;
                        investtotal = investtotal + invesvalo;

                        Console.WriteLine("o valor do rendimento é " + rend);
                        jurostotal = jurostotal + rend;
                    } }
                else
                {
                    Console.WriteLine("o tipo de investimento não existe");
                }
                

                Console.WriteLine("o total do valor do investimento é "+investtotal);
                Console.WriteLine("o total de juros é"+jurostotal);

                Console.WriteLine("Digite o cógido do cliente e 0 para sair");
                codicli = Convert.ToDouble(Console.ReadLine());

            }

            Console.WriteLine("fim");
            Console.ReadKey();
        }
    }
}
