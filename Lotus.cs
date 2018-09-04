using System

public class Program
{
    public static void Main()
    {
        int buds = 4;
        int lotus = 4;
        bool lotusbloom
        
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
        if (buds <= 0)
		{
			lotusbloom = true;
			
		}  else{

			lotusbloom = false


		}
		if (lotusbloom)
		{
			Console.WriteLine("All the lotus flowers bloom!");
		} else {

			Console.WriteLine("The lotus flowers do not bloom!")

		}

        
    }

}