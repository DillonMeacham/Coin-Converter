using System;

namespace CoinConvert
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Greet the user and capture input
            Console.WriteLine("Welcome to Coin Convert!");

            Console.Write("Please enter an amount to convert to coins: ");
            
            // Read user input as a string
            string totalAsString = Console.ReadLine();
            
            // Convert user input string to a double, rounding down to the nearest whole number
            double total = Math.Floor(Convert.ToDouble(totalAsString));

            Console.WriteLine($"{total} cents is equal to...");

            // coin values
            int gold = 10;
            int silver = 5;


            // Calculate gold coins
            double goldCoins = Math.Floor(total / gold);

            // Calculate remaining amount after gold coins
            double remainder = total % gold;

            // Calculate silver coins
            double silverCoins = Math.Floor(remainder / silver);

            // Update remainder to be the remaining amount after silver coins
            remainder = remainder % silver;

            // Display the results
            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {remainder}");
        }
    }
}
