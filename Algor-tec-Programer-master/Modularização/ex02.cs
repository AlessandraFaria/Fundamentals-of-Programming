using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void volume (ref int raio)
        {
            int vol=0, rara=0;
            rara=raio*raio*raio;
            vol = (4  * rara)/3;
            raio = vol;
            
        }


        static void Main(string[] args)
        {
            int r,volu;
            
            Console.WriteLine("digite o raio da esfera : ");
            r = Convert.ToInt32(Console.ReadLine());
            
            

            volume(ref r);
            Console.WriteLine("o volume da esfera é "+r);

            Console.Write("fim");
            Console.ReadKey();
        }
    }
}
