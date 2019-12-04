using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] demoArray = new int[] {0, 1};
            for (int i = 0; demoArray.Length < 8)
            {
                while (demoArray[i] != 8)
                {
                    demoArray[i] = Convert.ToInt32(Console.ReadLine());
                    if (i == 0)
                    {
                        Console.Write(", " + demoArray[i]);
                    }
                    else
                        Console.Write(demoArray[i] + ", ");
                }
                
            }
        }
    }
}
