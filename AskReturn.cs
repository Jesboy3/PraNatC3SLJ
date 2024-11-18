using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minigokker
{
    internal class AskReturn
    {
        public static int InlegVragen()
        {

            int inleg;
            Console.WriteLine("Hoeveel 4S muntjes wil je inleggen?");


            while (!int.TryParse(Console.ReadLine(), out inleg))
            {
                Console.WriteLine("Ongeldige invoer. Voer een getal in.");
            }

            return inleg;
        }

        public static int VraagNaarGetal()
        {
            int gok;
            Console.WriteLine("Wie denk je dat wint? Typ '1' voor de thuisploeg, '2' voor de uitploeg, of '3' voor gelijkspel.");

            while (!int.TryParse(Console.ReadLine(), out gok) || (gok < 1 || gok > 3))
            {
                Console.WriteLine("Ongeldige invoer. Typ '1' voor de thuisploeg, '2' voor de uitploeg, of '3' voor gelijkspel.");
            }

            return gok;
        }

    }
}
