using System;

namespace loopKeyPad;//do while 

class program
{
    static void Main(string[] args)
    {
        string password = "13579";
        string input = string.Empty;


        if (!input.Equals(password))
            while () ;
            {


                for (int i = 1; i < 5; i++) //attempt limit? 
                {

                    Console.WriteLine("Enter Keycode.: ");
                    input = Console.ReadLine();
                    Console.WriteLine("Incorrect KeyCode");
                    Console.WriteLine("Enter KeyCode");
                }
            }
            
        //Console.WriteLine("attempts exceeded max limit.");

        else  //trying to figure out attempt limit
        {
            Console.WriteLine("Welcome!:");
            Console.WriteLine("incorrect keycode:");
        }

    }
}