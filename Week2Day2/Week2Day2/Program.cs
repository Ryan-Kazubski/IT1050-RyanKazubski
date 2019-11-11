using System;

namespace Week2Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 0;
            //int incrementValue = 10;
            //int maxValue = 100;

            //while (x <= maxValue)
            //{
            //    if (x % 10 == 0)
            //    {
            //        Console.WriteLine(x);
            //    }
            //    x += incrementValue;
            //}

            //x = x - 10;

            // int minValue = -1;
            //while (x > minValue)
            //{
            //    if (x % 10 == 0)
            //    {
            //        Console.WriteLine(x);
            //    }
            //    x -= incrementValue;
            //}

            //int num = 11;

            //while (--num > 0)
            //{
            //    Console.WriteLine(num);
            //}

            int a = 0;
            int b = 0;
            int column1;
            int row1;
            Console.Write("Enter number of rows: ");
            row1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            column1 = Convert.ToInt32(Console.ReadLine());

            while (++b <= column1)
            {
                Console.Write("------");
            }

            Console.Write("\n");
            b = 0;
            while (++a <= row1)
            {
                while (++b <= column1)
                {
                    Console.Write("| {0},{1} ", a, b);
                }

                b = 0;
                Console.Write("\n");

                while (++b <= column1)
                {
                    Console.Write("------");
                }

                Console.Write("\n");
                b = 0;
            }

            


            

            

        }
    }
}
