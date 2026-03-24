using System;
using System.Text;

namespace csharp
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter name: ");
            String name = Console.ReadLine();

            Console.WriteLine("Enter age: ");
            String age = Console.ReadLine();

            Console.WriteLine("Your name is " + name + " and you are " + age + " years old");
        }
    }
}