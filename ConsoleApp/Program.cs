using System;

namespace ConsoleApp
{
    internal class Program
    {
        // The Main method is the starting point of our C# program.
        static void Main(string[] args)
        {
            // A variable is a container for storing data.
            // In this example, we've declared three integer variables:
            // "number_1", "number_2", and "total".
            int number_1 = 40;
            int number_2 = 70;

            // The + operator is used to perform addition.
            // In the following line, we're adding number_1 and number_2 and
            // storing the result in the total variable.
            int total = number_1 + number_2;

            // The {0}, {1}, and {2} placeholders in the Console.WriteLine statement are
            // used to insert the values of "number_1", "number_2", and "total" into the string.
            // ToString() is a method used to convert a value of another type to a "string" 
            Console.WriteLine("The sum of adding {0} and {1} is {2}", number_1.ToString(), number_2.ToString(), total.ToString());

            // Using String Interpolation
            // Step 1: Add a "$" sign before the string literal ("")
            // Step 2: Insert variables inside {} placeholders within the string
            // We can directly enclose variables within curly braces.
            String interpolatedString = $"The sum of adding {number_1} and {number_2} is {total}";

            // The Console.WriteLine method is used to write text to the console window.
            Console.WriteLine(interpolatedString);

            // Pause the console window until a key is pressed
            // This will prevent the output window from closing
            // until we press any key.
            Console.ReadKey();
        }
    }
}