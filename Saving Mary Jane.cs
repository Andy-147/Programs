using System;

namespace Saving_MJ_in_Spiderman
{
    class Program
    {
        static void Main(string[] args)
        {
            double webfluid = 100;
            double endurance = 100;
            double floorlevel = 0;
            double numoffloor;
            double rateweb;
            double endurerate;
            double floorleft = 0;
            string userinput;

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("How many floors are there? ");
            numoffloor = Convert.ToInt32(Console.ReadLine());

            if (numoffloor < 10)
            {
                numoffloor = 10;
            }

            Console.WriteLine("");
            Console.WriteLine("Spiderman has a total of 100 mL of web fluid and 100% of strength.");
            Console.WriteLine("");
            Console.WriteLine("How fast will Spiderman's web fluid level deplete?");
            rateweb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How fast will Spiderman's endurance level deplete?");
            endurerate = Convert.ToInt32(Console.ReadLine());

            while (floorlevel < numoffloor)
            {
                Decision:
                floorlevel++;
                Console.WriteLine("Mary Jane is in trouble. I've gotta save her.");
                Console.WriteLine("");
                Console.WriteLine("She is up on the top floor of this building. I have to get up there.");
                Console.WriteLine(" I can either use my webslinger to hop from floor to floor, or I can ");
                Console.WriteLine(" run up the stairs.");

                
                Console.WriteLine("");
                Console.WriteLine("How should I get to the next floor? Web or Stairs?");
                userinput = Console.ReadLine();

                switch (userinput)
                {
                    case ("web"):
                        webfluid = webfluid - rateweb;
                        floorleft = numoffloor - floorlevel;
                        break;

                    case ("stairs"):
                        endurance = endurance - endurerate;
                        floorleft = numoffloor - floorlevel;
                        break;
                    case ("nothing"):
                        floorlevel--;
                        floorleft = numoffloor - floorlevel;
                        break;
                }


                Console.WriteLine("");
                Console.WriteLine("Current Situation:");
                Console.WriteLine(" Floor Level: " + floorlevel);
                Console.WriteLine(" Web fluid remaining: " + webfluid);
                Console.WriteLine(" Endurance remaining: "+ endurance);
                Console.WriteLine(" Floors remaining: "+floorleft);
                Console.WriteLine("");

               if (webfluid < 0 && endurance < 0)
                {
                    

                }

            }




            Console.WriteLine("");
            
            Console.ReadLine();
         
        }
    }
}
