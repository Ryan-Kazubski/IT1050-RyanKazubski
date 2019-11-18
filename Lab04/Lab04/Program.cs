using System;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * 1.) The four basic elements are counter variable, initial value of the counter variable, increament or decreament variable, loop-continuation condition.
             * 2.) while loop - used for looping until a condition is satisfied and when it is unsure how many times the code should be in loop 
             *     for loop - used for looping until a condition is satisfied but it is used when you know how many times the code needs to be in loop
             * 3.) do while loop - executes the content of the loop once before checking the condition of the while. It is used when you always want
             *     your  problem to run at least once and then check to see if conditions are meet to keep repeating it.
             */

            for (int i = 1; i <= 100; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine("The variable is even.");
                }
                else
                {
                    Console.WriteLine("The variable is odd.");
                }
            }


            int temperature;
            Console.WriteLine("\nEnter the temperature.");
            temperature = Convert.ToInt32(Console.ReadLine());
            if (temperature < 10)
            {
                Console.WriteLine("Polar Bear");
            }
            else if (temperature < 20)
            {
                Console.WriteLine("Penguin");
            }
            else if (temperature < 40)
            {
                Console.WriteLine("Moose");
            }
            else if (temperature < 50)
            {
                Console.WriteLine("Reindeer");
            }
            else if (temperature < 60)
            {
                Console.WriteLine("Deer");
            }
            else if (temperature < 70)
            {
                Console.WriteLine("Turtle");
            }
            else if (temperature < 80)
            {
                Console.WriteLine("Lion");
            }
            else if (temperature < 90)
            {
                Console.WriteLine("Fish");
            }
            else
            {
                Console.WriteLine("Bug");
            }

            Console.WriteLine("\n");
            int n = 9;
            while (n++ < 20)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\n");
            for (int b = 0; b < 101; b++)
            {
                Console.WriteLine(b);
                Console.WriteLine("********");
            }


        }
    }
}
