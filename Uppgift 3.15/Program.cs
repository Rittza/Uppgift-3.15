using System;

namespace Uppgift_3_13
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen");
            int svar = int.Parse(Console.ReadLine());
            int avgift = 80;
            int pris = svar * avgift;


            if (svar >= 1 && svar < 11)
            {
                Console.WriteLine("Det kommer att kosta " + pris);

            }

            else if (svar > 11)
                Console.WriteLine("Du kan endast hyra en bil i tidsförloppet av 1-11 timmar");

        }
    }
}
