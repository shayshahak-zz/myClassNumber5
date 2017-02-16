using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5InClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this is loach ha kefel");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0}\t", i * j);
                }
                Console.WriteLine("\n");
            }

            // take name and while name different then my name the program will continue to run
            string myString= null;
            {
                while (myString != "shay")
                {
                    Console.WriteLine("enter your name");
                    myString = Console.ReadLine();
                }
            }
        }
    }
}
