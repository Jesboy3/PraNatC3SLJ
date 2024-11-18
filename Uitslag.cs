using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minigokker
{
    internal class Uitslag
    { 

        public static void IfUitslag()
        {
            int geld;
            int gok = AskReturn.VraagNaarGetal();

            Console.WriteLine();

            int inleg = AskReturn.InlegVragen();

            Console.WriteLine();

            // Geeft aan wie er wint en berekent wie er wint
            int winnaar = WinnerDecider.Winner();

            if ((gok == 1 && winnaar == 1) || (gok == 2 && winnaar == 2) || (gok == 3 && winnaar == 0))
            {
                Console.WriteLine("Gefeliciteerd! Je gok was correct.");
                geld = inleg + inleg;
                Console.WriteLine($"Je hebt {geld} 4S muntjes gewonnen!");
            }
            else
            {
                Console.WriteLine("Helaas, je gok was onjuist.");
            }

            Console.ReadLine();
        }
    }
}
