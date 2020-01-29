using System;

namespace GradeBook
{
    class Program
    {
        // method named Main
        static void Main(string[] args)
        {
            if (args.Length > 0) {
                Console.WriteLine($"Hello, {args[0]}!");

            }
        }
    }
}


// dotnet run Liz will only be a parameter for the dotnet CLI
// dotnet run --Liz makes it a variable for the application