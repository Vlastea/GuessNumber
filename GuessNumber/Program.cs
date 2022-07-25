using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the highest number in the range: ");
            int maxNum = int.Parse(Console.ReadLine());
            Random rand = new Random();
            int number = rand.Next(1, maxNum);
            string ent;
            int entNum;
            int retries = 0;

            Console.WriteLine($"\nLet's try! Guess the random number from 1 to {maxNum} by entering a number that you wanted. If you want to end the game, press \"Enter\"\n");
            while (true)
            {
                Console.Write(" Enter the number: ");
                ent = Console.ReadLine();
                retries++;

                if (ent != "")
                {
                    entNum = int.Parse(ent);

                    if (entNum < number)
                    {
                        Console.Write("The number is smaller.");
                    }

                    else if (entNum > number)
                    {
                        Console.Write("The number is bigger.");
                    }

                    else if (entNum == number)
                    {
                        Console.WriteLine($"\nYou won! The number is {number}");
                        break;
                    }

                }

                else
                {
                    Console.WriteLine($"The number is {number}");
                    break;
                }
            }
            Console.WriteLine($"Number of retires = {retries}");
            Console.ReadLine();
        }
    }
}
