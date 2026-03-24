using System;
using System.Text;

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

            double z = Convert.ToDouble(x) + 0.4;

            Console.WriteLine("x + y + z = " + x + y + z);
            Console.WriteLine(name + chr + "\n" + name.GetType() + " " + chr.GetType());
            Console.WriteLine("Im " + username + " and im " + age + " years old");
            Console.WriteLine("Pi = " + pi);
        }
    }
}