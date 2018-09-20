using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Startup

            string userinputA;

            Console.WriteLine("");
            Console.WriteLine("Start Menu");
            Console.WriteLine("");
            Console.WriteLine("Which file would you like to access?");
            Console.WriteLine("");
            Console.WriteLine("  1. Plays ");
            Console.WriteLine("  2. Terms and Definitions ");
            Console.WriteLine("  3. Scores ");
            Console.WriteLine("  4. Other ");
            Console.WriteLine("  5. Exit ");

            userinputA = Console.ReadLine();

            switch (userinputA)
            {
                case ("1"):
                    Console.WriteLine("  -User chose Plays-  ");
                    break;
                case ("plays"):
                    Console.WriteLine("  -User chose Plays-  ");
                    break;
                case ("2"):
                    Console.WriteLine("  -User chose T & D-  ");
                    break;
                case ("terms"):
                    Console.WriteLine("  -User chose T & D-  ");
                    break;
                case ("define"):
                    Console.WriteLine("  -User chose T & D-  ");
                    break;
                default:
                    Console.WriteLine("  -User didn't make a selection- ");
                    Console.WriteLine("  Please try again. ");
                    break;

            }
            Console.ReadLine();
        }
    }
}
