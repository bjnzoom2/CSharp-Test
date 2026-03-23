using System;

namespace csharp
{
    class Program
    {
        private static void Main(string[] args)
        {
            int x = 3;
            int y = 5;
            String name = "Pomni";
            Char chr = '#';

            String username = "Uzi";
            int age = 18;
            const double pi = 3.1415926f;

            Console.WriteLine(x + y);
            Console.WriteLine(name + chr);
            Console.WriteLine("Im " + username + " and im " + age + " years old");
            Console.WriteLine("Pi = " + pi);
        }
    }
}