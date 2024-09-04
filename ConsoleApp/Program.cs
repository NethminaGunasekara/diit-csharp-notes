// 1. The following statement means that we're using the
// System library (A built-in namespace called "System")
// from the .Net class library in our project. 
using System;
using System.Xml;

// Namespaces are used to group multiple classes together for better
// organization of classes within the project.
// Here, we're going to create a new namespace called "ConsoleApp", or
// include the Program class and it's content (methods, and fields/variables)
namespace ConsoleApp
{
    // The following class is used for including our Main method, which is the
    // entry point of our program.

    // A class is a blueprint for creating Objects. They contain both
    // data (attributes), and methods (actions).
    internal class Program
    {
        // The following method is the entry point of our C# program,
        // where the execution begins. Once we run our code,
        // this is the method to be invoked first by the runtime.

        // We defined the Main method as "static" to make it available for
        // the compiler to access by using the class name like -- Program.Main(),
        // without creating an Object of the Program class.
        static void Main(string[] args)
        {
            int number_1 = 40;
            int number_2 = 70;

            int total = number_1 + number_2;

            // The following is a way of adding values to placeholders
            // within the String passed to the WriteLine() method.
            Console.WriteLine("The sum of adding {0} and {1} is {2}", number_1.ToString(), number_2.ToString(), total.ToString());
            // -- Output: The sum of adding 40 and 70 is 110

            // String Interpolation is a way to add values to placeholders within a String.
            String interpolatedString = $"The sum of adding {number_1} and {number_2} is {total}";
            Console.WriteLine(interpolatedString);
            // -- Output: The sum of adding 40 and 70 is 110

            // The ReadKey() method of Console class prevents the command prompt from automatically
            // closing after we run the code. Console.ReadKey() method is used for reading a key from
            // our keyboard, which closes the output window once we press any key from the keyboard.
            Console.ReadKey();
        }
    }
}
