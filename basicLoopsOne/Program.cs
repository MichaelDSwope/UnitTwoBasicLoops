using System;


namespace basicloopsOne 
{
    class program 
    {
        static void Main(string[] args) 

        {
            Console.WriteLine("Enter a number.: ");
            string userInput = Console.ReadLine();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);


            }
            for (int i= 10; i > 0; i--) 
            {
            Console.WriteLine(i);

                while (true)
                {
                    string input = Console.ReadLine();

                    if (input.ToLower() == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                    Console.WriteLine("Would you like to continue? y/n " + input.ToUpper());
                }
                Console.WriteLine("Would you like to continue? y/n ");

            }
            Console.ReadKey();
        
        }
    
    
        
    }


}
