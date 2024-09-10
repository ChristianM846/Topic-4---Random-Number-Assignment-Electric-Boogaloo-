using System.Runtime.CompilerServices;

namespace Topic_4___Random_Number_Assignment__Electric_Boogaloo_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min, max;
            int dice1, dice2;
            int round;
            double random1, random2, random3;
            Random generator = new Random();

            // Part 1
            Console.WriteLine("Part 1 - Random Integers");
            Console.WriteLine("Hello user. Give me a minimum value and a maximum value, and I'll generate some whole numbers in that range.");
            Console.WriteLine("So, what is the minimum value? (Whole numbers only)");

            while (!Int32.TryParse(Console.ReadLine().Trim(), out min))
            {
                Console.WriteLine("That is not a valid input, please try again");
            }

            Console.WriteLine($"Okay, the minimum value will be {min}");
            Console.WriteLine("What is the maximum value (Will be inclusive)");

            while (!Int32.TryParse(Console.ReadLine().Trim(), out max) || max < min)
            {
                Console.WriteLine("That is not a valid input, please try again");
            }

            Console.WriteLine($"Okay, the maximum value is {max}, now let's generate some numbers!");
            Console.WriteLine($"Press ENTER to generate five numbers between {min} and {max} (Inclusive)");
            Console.ReadLine();
            Console.Write($"Okay, your five randomly generated numbers are:");

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($" {generator.Next(min, max+1)},");
            }

            Console.WriteLine();
            Console.WriteLine($"Press ENTER to continue");
            Console.ReadLine();

            //Part 2

            Console.WriteLine("Part 2 - Dice Roller");
            Console.WriteLine();
            Console.WriteLine("Let's roll some dice! Press ENTER to role the dice:");
            Console.ReadLine();

            dice1 = generator.Next(1,7);
            dice2 = generator.Next(1,7);

            Console.WriteLine($"Die 1 rolled a {dice1}, and die 2 rolled a {dice2}. That comes to a sum of {dice1 + dice2}");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            //Part 3

            Console.WriteLine("Part 3 - Random Decimal Numbers");
            Console.WriteLine();
            Console.WriteLine($"Remember those min and max values you entered earlier? {min} and {max}?");
            Console.WriteLine("Well we're going to use them again!");
            Console.WriteLine($"I'll generate 3 more number (Including Decimals) between {min} and {max}");
            Console.WriteLine("But first, how many decimal points should I round to? (Minimum of 1, Maximum of 14)");

            while (!Int32.TryParse(Console.ReadLine().Trim(), out round) || round < 1 || round > 14)
            {
                Console.WriteLine("That is not a valid input, please try again");
            }

            Console.WriteLine($"Okay, I'll round the numbers to {round} decimal places.");
            Console.WriteLine("Press ENTER to generate your three random numbers:");
            Console.ReadLine();
            Console.Write("Your three randomly generated numbers are:");

            random1 = Math.Round(generator.Next(min, max + 1) + generator.NextDouble(), round);
            random2 = Math.Round(generator.Next(min, max + 1) + generator.NextDouble(), round);
            random3 = Math.Round(generator.Next(min, max + 1) + generator.NextDouble(), round);

            if (random1 > max)
            {
                random1 = max;
            }
            if (random2 > max)
            {
                random2 = max;
            }
            if (random3 > max)
            {
                random3 = max;
            }

            Console.Write($"{random1}, {random2}, {random3}");
            Console.WriteLine();
            Console.WriteLine("Thank you for playing! Press ENTER to close the program");
            Console.ReadLine();
            Environment.Exit(0);



        }
    }
}
