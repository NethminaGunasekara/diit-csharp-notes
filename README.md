<br />
<div align="center">
  <a href="https://github.com/othneildrew/Best-README-Template">
    <img src="https://upload.wikimedia.org/wikipedia/commons/b/bd/Logo_C_sharp.svg" alt="Logo" width="80">
  </a>

  <h3 align="center">C# Notes</h3>

  <p align="center">
    The summary of C# lectures for DiIT students.
    <br />
    <a href="#table-of-contents"><strong>Table of contents »</strong></a>
    <br />
    <br />
    <a href="https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/overview">C# Guide</a>
    ·
    <a href="https://visualstudio.microsoft.com/vs/community">Visual Studio</a>
    ·
    <a href="https://dotnet.microsoft.com/en-us/download">.NET SDK</a>
  </p>
</div>

<details id="table-of-contents">
  <summary>Table of Contents</summary>
  
- [1. Program Structure](#1-program-structure)
  - [2.1. Namespaces](#21-namespaces)
    - [Real-World Analogy](#real-world-analogy)
    - [Why do we use namespaces?](#why-do-we-use-namespaces)
  - [2.2. Classes](#22-classes)

</details>

## 1. Program Structure

- A C# program is a collection of one or more files.
- Each file can contain zero or more namespaces.

This simple C# program calculates the sum of two integer numbers, `number_1` and `number_2`, and displays the `result` in two different formats: using _placeholders_ and using _string interpolation_.

It also uses the `Console.ReadKey()` method to prevent the console window from closing immediately after the output is displayed. The intended output is to show the calculated sum, along with an explanation of the arithmetic operation performed.

```cs
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
```

### 2.1. Namespaces

A namespace is a **logical grouping of related types**. It helps to organize code and avoid naming conflicts. `using System;` statement tells the compiler to include the System namespace in our code. This namespace provides many built-in classes and methods that are essential for developers.

If we didn't include the `System` namespace, we would have to call the `Console.WriteLine()` method as `System.Console.WriteLine()`.

- `System`: The System namespace

- `Console`: A class within the `System` namespace, which contains many useful methods like `WriteLine()`, `ReadLine()`, and `ReadKey()`

- `WriteLine()`: A method within the `Console` class

#### Real-World Analogy

A library is a place where books are organized into different sections. This helps readers find the books they need quickly.

In programming, namespaces are like these sections:

- Library: A programming project.
- Sections: Namespaces.
- Books: Classes, functions, and other code elements.

#### Why do we use namespaces?

- Organization: Namespaces help keep our code organized and easy to find.

- Avoid conflicts: Imagine two different books with the same title in the same section. It would be confusing! Namespaces prevent this by providing a unique "address" for each code element (e.g. `System.Console.WriteLine()` method from the `System` namespace's `Console` class).

### 2.2. Classes

A class is a blueprint for creating objects. It defines the properties and methods that an object will have.

- Attributes (properties): These are the characteristics or data that an object of the class will have. For example, a `Person` class might have attributes like `name`, `age`, and `address`.

- Behaviors (methods): These are the actions or functions that an object of the class can perform. For example, a `Person` class might have methods like `Walk()`, `Talk()`, and `Eat()`.
