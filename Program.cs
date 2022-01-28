using System;

public class Mainclass 
{
    public static void Main()
    {
        Console.WriteLine("Hi, Welcome to Bonnies' Buffet all you can eat for $9.99. " +
            "How many are in your group today? Please, parties of 6 or fewer.");
        int a = Convert.ToInt32(Console.ReadLine());

        if (a < 6)
        {
            Console.WriteLine("A table for " + a + "! You can follow me to your table.");


        } else { Console.WriteLine("Ain't nobody got time for that!");
            return;


        }





        Console.WriteLine("Let's get everyone started with some drinks. We've got soda and bottled water.");

        int water = 0;
        int soda = 0;
        decimal buffet = a;


        for (int i = 1; i <= a; i++)
        {


            Console.WriteLine(" Person number " + i + " water or soda? ");
            string input = Console.ReadLine();


            if (input == "water")
            {
                water++;
                Console.WriteLine("Water, Good choice! ");
                Console.WriteLine(water);
            } else if (input == "soda")

            {
                Console.WriteLine("Soda, Okay!");
                soda++;
                Console.WriteLine(soda);
            }

           
  
        }
        Console.WriteLine("Thank you for Dinning with us! Your total is:");
        decimal ftotal = 9.99m;
        decimal dtotal = 2.00m;

        Console.WriteLine(a * ftotal + a * dtotal);

    }
}