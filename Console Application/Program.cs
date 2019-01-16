using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the guessing game!");
            Console.WriteLine("Please pick a number between 0 and 100");
            Random Rand = new Random();
            int Number = Rand.Next(101);

            int In;
            int Count = 0;
            In = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(In);
            while (Number != In)
            {

                if (In < Number)
                {
                    Console.WriteLine("To Low");
                }

                else
                {
                    Console.WriteLine("To High");
                }

                Console.WriteLine("Please pick a number between 0 and 100");
                In = Convert.ToInt32(Console.ReadLine());
                Count++;

            }
            Console.WriteLine("You Won!");
            Console.WriteLine("You took " + Count + " tries");
        }
    }
}