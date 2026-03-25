using System;
using System.Text;

namespace csharp
{
    class Program
    {
        private static void Main(string[] args)
        {
            int x = 2; 
            for (int i = 0; i < 10; i++)
            {
                int y = Convert.ToInt32(Math.Pow(x, i));
                Console.WriteLine(y);
            }
            for (int i = 0; i < 10; i++)
            {
                double z = Math.Sqrt(x);
                Console.WriteLine(z);
            }
        }
    }
}