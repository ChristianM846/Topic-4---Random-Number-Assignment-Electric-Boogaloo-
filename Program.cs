namespace Topic_4___Random_Number_Assignment__Electric_Boogaloo_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min, max;
            int dice1, dice2;
            Random generator = new Random();

            // Part 1
            Console.WriteLine("Part 1");
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
            Console.WriteLine($"Okay, your five randomly generated numbers are:");

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($" {generator.Next(min, max+1)},");
            }





        }
    }
}
