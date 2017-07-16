using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int i = 0; i < 101; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    counter++;
                    Console.WriteLine(3 * counter);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
