using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minigokker
{
    internal class WinnerDecider
    {
        public static int Winner()
        {
            int Uitlslag = 0;
            int resultaat = 0;


            Random rng = new Random();

            int Thuisploeg = rng.Next(11);
            int Uitploeg = rng.Next(11);

            Console.WriteLine($"De score is geworden {Thuisploeg} - {Uitploeg}");

            if (Thuisploeg > Uitploeg)
            {

                Uitlslag = Thuisploeg - Uitploeg;
                Console.WriteLine("De thuisploeg heeft gewonnen!");
                Console.WriteLine($"Met {Uitlslag} punten verschil!");
                resultaat = 1;

            }
            else if (Uitploeg > Thuisploeg)
            {
                Uitlslag = Uitploeg - Thuisploeg;
                Console.WriteLine("De uitploeg heeft gewonnen!");
                Console.WriteLine($"Met {Uitlslag} punten verschil!");
                resultaat = 2;

            }
            else
            {
                Console.WriteLine("Gelijkspel");
                resultaat = 3;

            }

            return resultaat;
        }




    }
}
