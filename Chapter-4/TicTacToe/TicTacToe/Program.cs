using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main()
        {
            int win = 0;
            int lose = 0;
            int userInput;
            int[] answers = new int[] {};
            while (win != 1)
            {
                userInput = Convert.ToInt32(Console.ReadLine());
                answers.ToArray();

            }
            if (win == 1 && lose != 1)
            {
                Console.WriteLine("You win!!!");
            }
            else
                Console.WriteLine("You lose!!!");
            
       
        }

    }
}
