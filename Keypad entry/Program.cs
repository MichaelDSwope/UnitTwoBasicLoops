using System;

namespace loopKeyPad;

class program
{
    static void Main(string[] args)
    {
        string password = "13579";
        string input = string.Empty;
        int i = 0;

        if (!input.Equals(password))
        {
            for (int x = 0; x < 5; x++) //attempt limit 
            {

                Console.WriteLine("Enter Keycode.: ");
                input = Console.ReadLine();
                Console.WriteLine("Incorrect KeyCode");
                Console.WriteLine("Enter KeyCode");

            }

        }
        x > 5 Console.WriteLine("attempts exceeded max limit.");

        else  //trying to figure out attempt limit
        {
            Console.WriteLine("Welcome!:");
            Console.WriteLine("incorrect keycode:");
        }

    }
}

