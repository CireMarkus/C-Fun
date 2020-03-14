using System;

namespace First_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt user to enter a name.
            Console.WriteLine("Enter your name, please");

            //Now read the name entered.
            string name = Console.ReadLine();

            //Freet the user with the name that was entered.
            Console.WriteLine("Hello, " + name);


            //Wait for user to acknowlege the results. 
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
