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

            Console.WriteLine("Please pick a number to start from");
            int First;
            First = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please pick a number to end on");
            int Second;
            Second = Convert.ToInt32(Console.ReadLine());

            Random Rand = new Random();

            int Number = Rand.Next(First, Second);
            Console.WriteLine("I am thinking of a number between " + First + " and " + Second);
            Console.WriteLine("Begin Guessing!");

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