using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int userEntry = 0;
            int number = rnd.Next(1, 10);
            string choice;
            while (userEntry != number)
            {
                Console.WriteLine("Please enter a number between 1 and 10 >>>> ");
                userEntry = Convert.ToInt32(Console.ReadLine());
                if (userEntry == number)
                {
                    Console.WriteLine("How did you know it was {0}!?", userEntry);
                    Console.WriteLine("Would you like to go for double or nothing?");
                    choice = Console.ReadLine();
                    if (choice.Equals("Yes"))
                    {
                        Console.WriteLine("Congratulations, you are a degenerate gambler.");
                    }
                    else
                    {
                        Console.WriteLine("You should have quit while you were ahead.");
                    }
                }
                else
                {
                    Console.WriteLine("{0}? That was incorrect.", userEntry);
                }
            }
        }
    }
}
