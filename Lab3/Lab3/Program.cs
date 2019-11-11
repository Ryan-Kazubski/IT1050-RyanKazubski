using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* They are different because if an if statement will run once for if an argument is true while a while statement will keep running as long as the statement is true.
            They are similar though because if the statement is false both while and if statements will skip to the next line of code out of the if or while. */

            //Declaring in variables.
            int speedLimit = 35;
            int speed = 42;

            // using if to determine if the person is speeding over the speed limit.
            if (speed > speedLimit)
            {
                Console.WriteLine("SLOW NOW");
            }

            Console.WriteLine("-----------------------------\n");

            //-----------------------------------------------------------------------------------------------------------

            // Declaring bool variables.
            bool isTrue = true;

            // using if to determine if isTrue is true or false and outputting the answer.
            if (isTrue == true)
            {
                Console.WriteLine("It is True!");
            }
            else
            {
                Console.WriteLine("It is False!");
            }

            Console.WriteLine("-----------------------------\n");

            // -----------------------------------------------------------------------------------------------------------

            // declaring celsius and farenheit as our 2 variables.
            double fahrenheit;
            double celsius;

            // asking user to input farenheit and converiting it to our variable.
            Console.Write("Input the temperature in fahrenheit: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            // converting fahrenheit to calesius.
            celsius = (fahrenheit - 32d) * 5d / 9d;

            // outputting the temperature in celsius.
            Console.WriteLine("The temperature is {0} degrees celsius", celsius);

            // using if to determine if the fahrenheit temperature is hot or cold and outputting the result.
            if (fahrenheit < 40)
            {
                Console.WriteLine("It is cold");
            }
            else if (fahrenheit > 90)
            {
                Console.WriteLine("It is hot");
            }

            Console.WriteLine("-----------------------------\n");

            //------------------------------------------------------------------------------------------------------------

            //a while loop that outputs values 1 to 10.  Incrementing by 1.

            // Declaring variable
            int a = 0;

            // running a while loop to increment up by one and only outputting 1-10.
            while (a++ <= 9)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("-----------------------------\n");

            //--------------------------------------------------------------------------------------------------------------

            //a while loop that outputs values 60 to 20.  Decrementing by 5.

            //declaring variables
            int x = 61;

            // running a while loop to decrement by 5 and only outputting 60-20.
            while (x-- >= 20)
            {
                if (x % 5 == 0)
                {
                    Console.WriteLine(x);
                }
            }

            Console.WriteLine("-----------------------------\n");

            //----------------------------------------------------------------------------------------------------------------

            // a while that outputs values 10-20. Incrementing by 2.

            //declaring variable
            int num = 10;

            // running a while loop to increment by 2 and only outputting 10-20.
            while (num <= 20)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
                num += 2;
            }
        }
    }
}
