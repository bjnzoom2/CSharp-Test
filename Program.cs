using System;
using System.Globalization;
using System.Text;

namespace csharp
{
    class Program
    {
        private static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                List<int> nums = new List<int>();
                int count = 10;
                for (int i = 0; i < count; i++)
                {
                    Random rand = new Random();
                    nums.Add(rand.Next(0, 100));
                }
                Console.WriteLine(count + " random numbers have been generated, guess one");
                String guessed;

                bool correct = false;
                int chances = 4;
                while (!correct && chances >= 0)
                {
                    guessed = Console.ReadLine();
                    for (int i = 0; i < count; i++)
                    {
                        if (guessed == nums[i].ToString())
                        {
                            correct = true;
                            Console.WriteLine("Correct");
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (!correct)
                    {
                        Console.WriteLine("Try Again");
                        chances -= 1;
                    }
                }

                if (chances < 1)
                {
                    Console.WriteLine("Failed");
                    running = false;
                    Console.Write("Numbers were: ");
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write(nums[i]);
                        if (i != count - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}