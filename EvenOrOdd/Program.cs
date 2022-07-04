using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            var play = true;
            while (play)
            {
                Console.WriteLine("Please give me the number and I'll tell you if it's even or not:");
                if (!long.TryParse(Console.ReadLine(), out long num))
                {
                    Console.WriteLine("You have to give me a number. Please try again.");
                    continue;
                }
                if (num % 2 == 0)
                {
                    Console.WriteLine("The number you gave to me is Even.");
                }
                else
                {
                    Console.WriteLine("The number you gave to me is Odd.");
                }

                Console.WriteLine("Do you wanna check another number? Yes or No:");
                var userInput = Console.ReadLine();
                var list = new List<string>() { "Y", "y", "yes", "Yes" };
                if (list.Contains(userInput))
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    play = false;
                }

            }
        }
    }
}
