using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Playbook_Program_B
{
    class Program
    {
        static void Main(string[] args)
        {
            // Andrew Austin 
            
            Soccerplays soccerplays = new Soccerplays();
            ScoreOption1 scoreOption1 = new ScoreOption1();
            Terms terms = new Terms();
            OtherOptions otherOptions = new OtherOptions();

            //Startup Menu

            string userinputA;

            StartupMenu:
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Start Menu");
            Console.WriteLine("");
            Console.WriteLine(" Which file would you like to access?");
            Console.WriteLine("");
            Console.WriteLine("   1. Plays ");
            Console.WriteLine("   2. Terms and Definitions ");
            Console.WriteLine("   3. Scores ");
            Console.WriteLine("   4. Other ");
            Console.WriteLine("   5. Exit ");
            Console.WriteLine("");

            userinputA = Console.ReadLine();

            Remake:
            //Checks for captialization
            if (userinputA == "Plays" || userinputA == "plays")
            {
                userinputA = "1";
            }else if (userinputA == "Terms" || userinputA == "terms" || userinputA == "define" || userinputA == "Define")
            {
                userinputA = "2";
            }
            else if (userinputA == "Scores" || userinputA == "scores" || userinputA == "score" || userinputA == "Score")
            {
                userinputA = "3";
            }else if (userinputA == "Other" || userinputA == "other")
            {
                userinputA = "4";
            }
            else if (userinputA == "Exit" || userinputA == "exit" || userinputA == "leave")
            {
                userinputA = "5";
            }

            // Sends user to a particular class depending on their choice.
            switch (userinputA)
            {
                case ("1"):
                    Console.WriteLine("  -User chose Plays-  ");
                    soccerplays.Playverse();
                    break;
                case ("2"):
                    Console.WriteLine("  -User chose T & D-  ");
                    terms.Definitions();
                    break;
                case ("3"):
                    Console.WriteLine("  -User chose Scores-  ");
                    scoreOption1.GetScores();
                    break;
                case ("4"):
                    Console.WriteLine("  -User chose Other-  ");
                    otherOptions.Options();
                    break;
                case ("5"):
                    Console.WriteLine("  -User chose Exit-  ");
                    goto Leave;
                
                default:
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("   1. Plays ");
                    Console.WriteLine("   2. Terms and Definitions ");
                    Console.WriteLine("   3. Scores ");
                    Console.WriteLine("   4. Other ");
                    Console.WriteLine("   5. Exit ");
                    Console.WriteLine("");
                    Console.WriteLine("  -User didn't make a selection- ");
                    Console.WriteLine("   Please try again. ");
                    Console.WriteLine("");
                    userinputA = Console.ReadLine();
                    goto Remake;
            }

            goto StartupMenu;

            Leave:
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("   Thank you and have a nice day.");
            Console.WriteLine("");

            Console.ReadLine();

           
            
        }
    }

    class Soccerplays
    {
        public void Playverse()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" Select which plays you would like to observe.");
            Console.WriteLine("");
            Console.ReadLine();

        }
    }


    class Terms
    {
        public void Definitions()
        {
            Console.Clear();
            if (!System.IO.File.Exists(@"C:\Users\austin-52511\Writing\terms.txt"))
            {

                System.IO.File.Create(@"C:\Users\austin-52511\Writing\terms.txt");
            }
      
            string uiTerms;
            string line;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" Please enter the term you would like to search: ");
            uiTerms = Console.ReadLine();
            Console.WriteLine("");

            if (uiTerms == "fullback" || uiTerms == "backs")
            {
                uiTerms = "defender";
                goto DefinitionAccess;
            }
            else if (uiTerms == "striker" || uiTerms == "Striker")
            {
                uiTerms = "forward";
                goto DefinitionAccess;
            }
            else if (uiTerms == "keeper" || uiTerms == "goalie")
            {
                uiTerms = "goalkeeper";
                goto DefinitionAccess;
            }
            
            DefinitionAccess:
            // Displays Term Definitions
            switch (uiTerms)
            {
                case ("defender"):
                    Console.WriteLine("");
                    Console.WriteLine("Defender");
                    Console.WriteLine("");
                    Console.WriteLine("");


                    break;






            }





          


            Console.WriteLine("");
            Console.WriteLine(uiTerms);
            Console.WriteLine("");




            Console.ReadLine();
            Console.Clear();
        }

    }

    class ScoreOption1
    {
        public void GetScores()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Scores are numbers.");
            Console.ReadLine();
        }
    }

    class OtherOptions
    {
        public void Options()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Other Options within this program.");
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}

