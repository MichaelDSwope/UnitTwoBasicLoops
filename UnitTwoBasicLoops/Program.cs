using System;
using System.Linq;


class basicLoops
{
    static void Main()
    {
        Console.WriteLine("Hello World!" + "(Would you like to continue?:  y/n)");

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "n")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            Console.WriteLine("Hello World! Would you like to continue? y/n " + input.ToUpper());
            }
        }
}
















