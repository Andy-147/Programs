using System;

public class Program
{
    public static void Main()
    {
        int buds = 4;
        int lotus = 4;
        
        
        for (int numberofbuds = 0; numberofbuds <= lotus; numberofbuds++)
        {


            buds--;

            lotus--;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("How many buds are left? " + buds);
            Console.WriteLine("");
            Console.WriteLine("How many lotus flowers are left? " + lotus);
            Console.WriteLine("---------------------------------");

        }
   		
		switch (buds)
		{
			case 0:
			Console.WriteLine("All of the lotus flowers bloomed!");
			break;
			
			case 1:
			Console.WriteLine("Three of the lotus flowers bloomed!");
			break;
			
			case 2:
			Console.WriteLine("Two of the lotus flowers bloomed!");
			break;
				
			case 3:
				Console.WriteLine("One of the lotus flowers bloomed!");
			break;
				
			case 4:
				Console.WriteLine("None of the lotus flowers bloomed!");
				break;
			
			default:
			Console.WriteLine("Incomplete data... Try again :p");
			break;
				
			
		}

        Console.WriteLine("");
		Console.WriteLine("_______________________________________________________");
		Console.WriteLine(".");
    }

}