using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {

        // method named Main
        static void Main(string[] args)
        {
            // declaring an array of double point numbers called numbers
            // initiating an explicite size with new double[numberInArray]
            // curly braces declares what goes into the array
            // new [] says you dont know how long the array is and it will figure out the types for you
            var numbers = new[] {12.7, 10.3, 6.11, 4.1};
            // if empty array then decalre them like you do in JS like this:
            // numbers[0] = 12.7;

            var grades = new List<double>() {12.7, 10.3, 6.11, 4.1};
            grades.Add(56.1);

            var result = 0.0;
            foreach(double number in grades)
            {
                result += number;
            }
            var average = result / grades.Count;
            System.Console.WriteLine($"The average grade is {average}");
            // var is still strongly typed not like JS. it will only hold a "double" if it's a double or string if it's a string.

            if (args.Length > 0) {
                Console.WriteLine($"Hello, {args[0]}!");
            } else {
                Console.WriteLine("Hello!");
            }
        }
    }
}


// dotnet run Liz will only be a parameter for the dotnet CLI
// dotnet run --Liz makes it a variable for the application