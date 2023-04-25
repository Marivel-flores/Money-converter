using System;

namespace Money_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            //step 1: Run the code once to understand the starting code. Use dotnet run in the terminal.
            Console.WriteLine("Welcome to Money Maker!");

            //step 2: Use Console.WriteLine() and Console.ReadLine() to ask the user for the amount to convert and capture the value in a variable.
            Console.WriteLine("Enter a value to convert coins: ");
            string ValueEntered = Console.ReadLine();

            //step 3
            double value = Convert.ToDouble(ValueEntered);

            //step 4
            Console.WriteLine($"{value} cents is equal to...");

            //step 6
            int diamondValue = 25;
            int goldValue = 10;
            int silverValue = 5;

            //step 7: 1 = 11 / 10;
            double diamondCoins = Math.Floor(value / diamondValue);
            double diamondLeftOver = value % diamondValue;
            double goldCoins = Math.Floor(diamondLeftOver / goldValue);

            //step 8: remainder = 11 / 10;
            double goldLeftOver = diamondLeftOver % goldValue;

            //step 9 
            double silverCoins = Math.Floor(goldLeftOver / silverValue);

            //step 10
            double remainder = goldLeftOver % silverValue;

            //step 11
            Console.WriteLine($"Diamond coins: {diamondCoins}");
            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {remainder}");




        }
    }
}
