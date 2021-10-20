using System;

namespace Pokupka_biletov
{
    class Program
    {

        static int Saali_suurus()
        {
            Console.WriteLine("Vali saali suurus: 1,2,3");
            int suurus = int.Parse(Console.ReadLine());
            return suurus;
        }
        static int[,] saal = new int[,] { };
        static int kohad, read;


        static void Saali_taitmine(int suurus)
        {
            Random rnd = new Random();
            if (suurus==1)
            {
                kohad = 20;
                read = 10;
            }
            else if (suurus==2)
            {
                kohad = 20;
                read = 20;
            }
            else
            {
                kohad = 30;
                read = 20;
            }
            saal = new int[read, kohad];
            for (int rida = 0; rida < read; rida++)
            {
                for (int koht = 0; koht < kohad; koht++)
                {
                    saal[rida, koht] = rnd.Next(0, 2);
                }

            }

        }
        static void Saal_ekraanile()
        {
            for (int rida = 0; rida < read; rida++)
            {
                for (int koht = 0; koht < kohad; koht++)
                {
                    Console.Write(saal[rida, koht]);
                }
                Console.WriteLine();
            }
        }
        static bool Muuk()
        {
            Console.WriteLine("Rida");
            int pileti_rida = int.Parse(Console.ReadLine());
            Console.WriteLine("Koht");
            int pileti_koht = int.Parse(Console.ReadLine());
            if (saal[pileti_rida-1,pileti_koht - 1]==0)
            {
                saal[pileti_rida - 1, pileti_koht - 1] = 1;
                return true;
            }
            else 
            {
                return false;
            }
        }

        public static void Main(string[] args)
        {

            int suurus = Saali_suurus();
            Saali_taitmine(suurus);
            while (true)
            {
                Saal_ekraanile();
                bool ost = Muuk();

                Console.WriteLine(ost);

            }



            /*Console.WriteLine("Sisesta rida: ");
            int rjad = int.Parse(Console.ReadLine());
            int stop = 0;
            do
            {
                if (rjad > 0  &&  rjad < 21)
                {
                    Console.WriteLine("Sisesta kohta: ");
                    int kohta = int.Parse(Console.ReadLine());
                    if (kohta > 0 && kohta < 31)
                    {
                        Console.WriteLine("Kupili mesto");
                    }
                    else
                    {
                        Console.WriteLine("netu takokogo");
                    }
                }
                else
                {
                    Console.WriteLine("netu takokogo");
                }
                Console.WriteLine("Xvatit? - 1");
                stop = int.Parse(Console.ReadLine());

            } while (stop != 1);
            Console.WriteLine("Spasibo");*/

             Console.ReadLine();
        }

    }
}
