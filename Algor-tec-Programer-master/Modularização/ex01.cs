using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        public static void minutos(ref int conv,ref int conhor,ref int conse)
        {
            conv = conv * 60;
            conhor = conhor * 120;
            conse = conse+conhor+conv;

        }
       
        static void Main(string[] args)
        {
            int min, hor,seg;

            Console.WriteLine("digite os valores ");
            Console.WriteLine("horas ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("minutos");
            hor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("segundos");
            seg = Convert.ToInt32(Console.ReadLine());


            minutos(ref min,ref hor,ref seg);
            Console.WriteLine("o resultado do total de segundos é  "+seg);

            Console.Write("fim");
            Console.ReadLine();
        }
       
    }
}
