using System;

namespace Homework_help
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 61;
            while (x-- >= 20)
            {
                if (x % 5 == 0)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
