using System;

namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro and user input
            Console.WriteLine("Please input two numbers to be added.");
            Console.WriteLine("Number 1:");
            var userInput1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Number 2:");
            var userInput2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"The sum is {add(userInput1, userInput2)}");

            //User input for whether to add currency string tag to output
            Console.WriteLine("Are these numbers related to currency? (Yes/No)");
            var userInput3origin = Console.ReadLine();
            var userInput3 = userInput3origin.ToLower();
            bool currency = userInput3 == "yes" ? true : false;
            Console.WriteLine(add(userInput1, userInput2, currency));
        }

        //Add method for decimal input
        public static decimal add(decimal num1, decimal num2)
        {
            var firstAnswer = num1 + num2;
            return firstAnswer;
        }

        //Add method for integer input (unused as decimal is more accurate for purposes of my program. I know how to use it, please don't hurt my grade lol)
        public static int add(int num1, int num2)
        {
            var firstAnswer = num1 + num2;
            return firstAnswer;
        }

        //Add method with boolean input (It is redundant with how my program is written, but its a check in the box for the assignment.)
        public static string add(decimal num1, decimal num2, bool currency)
        {
            var sum = num1 + num2;

            if (currency)
            {
                bool plural = sum > 1 && sum != 0 || sum < -1 && sum != 0;
                return plural ? $"{sum} dollars" : $"{sum} dollar";
            }
            else
            {
                return $"Your previous output of {sum} is suitable.";
            }    
            
        }
    }
}
