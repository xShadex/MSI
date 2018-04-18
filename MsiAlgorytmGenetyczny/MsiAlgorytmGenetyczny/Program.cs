using MsiAlgorytmGenetyczny;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsiAlgorytmGenetyczny
{

    public class Chromosom
    {
        public int dlChromosomu = 10;
        int dlPopulacji = 5;
        string[] pattern;
        int licznik = 0;



        public void Pattern()
        {
            Random rand = new Random();
            pattern = new string[dlChromosomu];

            for (int i = 0; i < dlChromosomu; i++)
            {
                pattern[i] = rand.Next(0, 2).ToString();
            }
            foreach (var item in pattern)
            {
                Console.Write(item);
            }
        }

        public void LosujPopulacje()
        {
            Random rand1 = new Random();

            string[,] populacja = new string[dlPopulacji, dlChromosomu];

            for (int i = 0; i < dlPopulacji; i++)
            {
                for (int j = 0; j < dlChromosomu; j++)
                {
                    populacja[i, j] = rand1.Next(0, 2).ToString();
                }
            }

            for (int a = 0; a < dlPopulacji; a++)
            {
                for (int b = 0; b < dlChromosomu; b++)
                {
                    Console.Write(populacja[a, b]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < dlPopulacji; i++)
            {
                for (int j = 0; j < dlChromosomu; j++)
                {
                    if (populacja[i, j] == pattern.ToString())
                    {
                        ++licznik;
                    }

                }

            }

            if (licznik > 0)
            {
                Console.WriteLine("Patern zostal odnaleziony w populacji");
            }
            else
            {
                for (int i = 0; i < dlPopulacji/2; i++)
                {
                    for (int j = 0; j < dlChromosomu/2; j++)
                    {
                        
                    }
                }
            }


        }






    }
}
public class Program
{
    static void Main(string[] args)
    {
        Chromosom a = new Chromosom();
        a.Pattern();

        Console.WriteLine();
        Console.WriteLine();

        a.LosujPopulacje();



    }
}

