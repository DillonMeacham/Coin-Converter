using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Greet the user and capture input
            Console.WriteLine("Welcome to Money Maker!");

            Console.Write("Please enter an amount to convert to coins: ");

            string totalAsString = Console.ReadLine();

            double total = Math.Floor(Convert.ToDouble(totalAsString));

            Console.WriteLine($"{total} cents is equal to...");

            // convert to coins

            int gold = 10;
            int silver = 5;

            double goldCoins = Math.Floor(total / gold);

            double remainder = total % gold;

            double silverCoins = Math.Floor(remainder / silver);

            remainder = remainder % silver;

            Console.WriteLine($"Gold coins: {goldCoins}");

            Console.WriteLine($"Silver coins: {silverCoins}");

            Console.WriteLine($"Bronze coins: {remainder}");
        }
    }
}
