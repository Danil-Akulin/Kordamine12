using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kordamine
{
    class Startclass
    {
        public const int leib = (int)2.81;
        public const int sai = (int)2.81;
        public const int piim = (int)2.81;
        public static void Main(string[] args)
        {
            Console.WriteLine("Hi");
            string eesnimi = Console.ReadLine();
            string naabriNimi = Console.ReadLine();
            //Console.WriteLine("Hi, " + eesnimi);

            if (eesnimi.ToLower() == "juku")
            {
                Console.WriteLine("Mis on sinu aasta" + eesnimi);
                int juku_old = int.Parse(Console.ReadLine());
                if (juku_old < 0 || juku_old>=120)
                {
                    Console.WriteLine("Viga andmetega!");
                }
                else if (juku_old<6)
                {
                    Console.WriteLine("juku go free");
                }
                else if (juku_old>=7 && juku_old<=14)
                {
                    Console.WriteLine("Lastepilet");

                }

                else if (juku_old>=15 && juku_old<65)
                {
                    Console.WriteLine("täispiletid");

                }
                else if (juku_old>=66)
                {
                    Console.WriteLine("Sooduspiletid");
                }


            }

            else
            {
                Console.WriteLine("Halvasti");
            }

            // второе задание

            Console.WriteLine(eesnimi+ " ja " + naabriNimi + "te olete tänu naabrid");

            // третье задание
            Console.WriteLine("Write dlinu tvoego loza");
            int dlina = int.Parse(Console.ReadLine());
            Console.WriteLine("Write sirinu tvoego loza");
            int sirina = int.Parse(Console.ReadLine());

            Console.WriteLine(dlina * sirina + " " + " see on sinu Pjosjad");
            Console.WriteLine("Write do you wanna do new pol");
            Console.WriteLine("1 - yes, 0 - no");

            int jah_voi_ei_remontiPorand = int.Parse(Console.ReadLine());

            if (jah_voi_ei_remontiPorand == 1)
            {
                Console.WriteLine("Kui suur ruud metrid");
                decimal meetrid_hind = decimal.Parse(Console.ReadLine());
                Console.WriteLine("mis hind m2 sulle sobib?");
                int hind_m2 = int.Parse(Console.ReadLine());


                meetrid_hind = meetrid_hind * hind_m2;
                Console.WriteLine(meetrid_hind + " see on sinule hind koik remontid");

            }
            else
            {
                Console.WriteLine("doesn't matter");

            }

            // четвёртое задание
            Console.WriteLine("Write how many money sinu phone");
            int stoimost_phone = int.Parse(Console.ReadLine());
            if (stoimost_phone>0)
            {
                stoimost_phone = (stoimost_phone / 100) * 70;
                Console.WriteLine("without skidki - " + stoimost_phone);
            }
            else
            {
                Console.WriteLine("sisestasite negatiivse väärtuse");

            }



            // пятое задание

            Console.WriteLine("Write sulle palavik");
            int palavik_eesimene_player = int.Parse(Console.ReadLine());

            if (palavik_eesimene_player>=17)
            {
                Console.WriteLine("You have " + palavik_eesimene_player + " palavik"+ " " + " see on tore ");

            }
            else
            {
                Console.WriteLine("You have " + palavik_eesimene_player + " palavik" + " " + "vaja soojeneda ");

            }


            // шестое задание

            Console.WriteLine("Write sulle rost");
            Console.WriteLine("do 150 - karlik, do 180 - simple, 180> - gigant");
            int rost = int.Parse(Console.ReadLine());


            if (rost<=150)
            {
                Console.WriteLine("sa oled karlik");

            }

            else if (rost>150 && rost<180)
            {
                Console.WriteLine("sa oled simple");
            }
            else if (rost>=180)
            {
                Console.WriteLine("Sa oled gigant");
            }
            else
            {
                Console.WriteLine("i broken");
            }

            // седьмое задание

            Console.WriteLine("For mehed do 150 - karlik, do 180 - simple, 180> - gigant");
            Console.WriteLine("For naine do 140 - karlik, do 170 - simple, 170> - gigant");
            Console.WriteLine("Write sulle rost v2.0");
            string rost_mehed_naised = Console.ReadLine();
            Console.WriteLine("sa oled mehed või naine?");
            string mehed_või_naised = Console.ReadLine();


            if (mehed_või_naised == "mehed")
            {
                if (rost <= 150)
                {
                    Console.WriteLine("sa oled karlik");

                }

                else if (rost > 150 && rost < 180)
                {
                    Console.WriteLine("sa oled simple");
                }
                else if (rost >= 180)
                {
                    Console.WriteLine("Sa oled gigant");
                }
                else
                {
                    Console.WriteLine("i broken");
                }
            }
            else if (mehed_või_naised == "naine")
            {
                if (rost <= 140)
                {
                    Console.WriteLine("sa oled karlik");

                }

                else if (rost > 140 && rost < 170)
                {
                    Console.WriteLine("sa oled simple");
                }
                else if (rost >= 170)
                {
                    Console.WriteLine("Sa oled gigant");
                }
                else
                {
                    Console.WriteLine("i broken");
                }
            }
            else
            {
                Console.WriteLine("i was broken");

            }

            // восьмое задание

            Console.WriteLine("Tere, ma olen robot konsultant");
            Console.WriteLine("sisestage vajalik toode");
            Console.WriteLine("1 - leib");
            Console.WriteLine("2 - sai");
            Console.WriteLine("3 - piim");
            int poodi_toit = int.Parse(Console.ReadLine());


            if (poodi_toit==1)
            {
                Console.WriteLine("sa tegid leib");
                Console.WriteLine("leib maksab " + leib);
            }
            else if (poodi_toit==2)
            {
                Console.WriteLine("sa tegid sai");

            }
            else if (poodi_toit==3)
            {
                Console.WriteLine("sa tegid piim");

            }



            int first_number = int.Parse(Console.ReadLine());
            int second_number = int.Parse(Console.ReadLine());

            Console.WriteLine("Arvude {0} ja {1}", first_number, second_number, first_number * second_number);





            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
