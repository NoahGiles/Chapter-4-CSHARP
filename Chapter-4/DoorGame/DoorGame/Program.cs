using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int doorChoose;
            Console.WriteLine("Pick a door 1, 2, or 3");
            doorChoose = Convert.ToInt32(Console.ReadLine());
            if (doorChoose == 1)
            {
                Console.WriteLine("It is poop. Idiot.");
            }
            else if (doorChoose == 2)
            {
                Console.WriteLine("It is pee. Idiot.");
            }
            else if (doorChoose == 3)
            {
                Console.WriteLine("Whatever number 3 is. Probably poop and pee.");
            }
            else
            {
                Console.WriteLine("You are idiot. Not an option.");
            }
        }
    }
}
