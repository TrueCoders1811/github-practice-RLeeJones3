using System;

namespace DisplayInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get first and last name from user input
            string firstName = "";
            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            string lastName = "";
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
            int favNumb = 0;
            Console.WriteLine("What is your favorite number?");
            favNumb = int.Parse(Console.ReadLine());
            string favAnimal = "";
            Console.WriteLine("What is your favorite animal?");
            favAnimal = Console.ReadLine();
            Console.WriteLine("Your first name is " + firstName);
            Console.WriteLine("Your last name is " + lastName);
            if (favNumb > 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            else if (favNumb < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            
            Console.WriteLine("Your favorite number is " + favNumb);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Your favorite animal is " + favAnimal);
            
            // Get their favorite number
            // Get their favorite animal

            // Once you have gotten all their info and stored it,
            // display it back to them.

            // If their favorite number is greater than 10, display it in green.
            // If their favorite number is less than 5, display it in red.
        }
    }
}
