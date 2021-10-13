using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class Kordused
    {

        static void Main(string[] args)
        {
            string[] nimed = new string[6] { "Danil", "Aasakula", "Blinob", "Jaan", "Erik", "Nicolai" };
            nimed[2] = "Anna";
            int nr = 0;

            while (nr<6)
            {
                Console.WriteLine("Tere, {0} opilane", nimed[nr]);
                nr++;
            }


            Console.WriteLine("SECOND");
            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine("Tere, {0} opilane", nimed[i]);
            }


            Console.WriteLine("THIRD");
            foreach (var nimi in nimed)
            {
                Console.WriteLine("Tere, {0} opilane", nimi);
            }
            
            Console.WriteLine("FOURD");
            //do
            //{

            //    Console.WriteLine("Tere, {0}. matkaja!", nr);

            //    nr = nr + 1;

            //} while (nr != 5);
            /*
                           //первое задание
            Random rnd = new Random();

            int N = rnd.Next(2, 5);
            int M = rnd.Next(6, 10);
            int[] mass = new int[M - N];

            for (int i = N; i < M + 1; i++)
            {
                mass[i - N] = i;
                Console.WriteLine(" {0} ", i * i);
            }
            foreach (var m in mass)
            {
                Console.WriteLine(m);
            }

            */
                         //второе задание

            






            Console.ReadLine();

        }

    }
}