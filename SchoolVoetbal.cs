using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Minigokker
{
    internal class SchoolVoetbal
    {
        public int Uitlslag {  get; set; }
        public int resultaat;

        public void GokMenu()
        {
            while (true) {

                Commands.MenuString();
                string? answer = Console.ReadLine().ToLower();

                if (answer == "1")
                {
                    Console.Clear();

                    Console.WriteLine($"{answer}, Gokje wagen");


                    Console.WriteLine();
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine();


                    Uitslag.IfUitslag();
                }

                else if (answer == "2")
                {
                    Console.Write(answer);
                }
                else if (answer == "3")
                {
                    Console.Write(answer);
                }
                else if (answer == "4")
                {
                    Console.Write(answer);
                }
                else if (answer == "x")
                {
                    break;
                }

                Console.Clear();

            }
        }

    }
}
