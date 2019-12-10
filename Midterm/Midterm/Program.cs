using System;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean keeplooping = true;

            while (keeplooping == true)
            {
                Console.WriteLine("0");
            }

            int i = 2;

            while (i < 128)
            {
                Console.WriteLine("[" + i + "]");

                if (i == 64)
                {
                    break;
                }
                i = i * 2;
            }

            Console.WriteLine("\n");
            for (i = 49; i >= 1; --i)
            {

                Console.Write(i);

                if (i >= 2)
                {
                    Console.Write(",");
                }

            }

            i = 1;

            Console.WriteLine("\n");

            while (i <= 21)
            {
                if (i % 2 == 1)
                {
                    Console.Write($"{i} ");
                }

                i = i + 1;
            }

            Console.WriteLine("\n");

            Boolean icyrain = false;
            Boolean tornadowarning = false;

            if (icyrain == false && tornadowarning == false)
            {
                Console.WriteLine("lets go outside");
            }

            Console.WriteLine("\n");

            int num = 5;

            for (int k = 5; k >= 1; --k)
            {
                for (int h = 5; h > num; h--)
                {
                    Console.Write(" ");
                }
                for (int h = 1; h <= (num - 1); ++h)
                {
                    Console.Write(h);
                }
                for (int h = 0; h < num; ++h)
                {
                    Console.Write(num - h);
                }

                Console.WriteLine();

                num = num - 1;
            }

            /* What is the output for the following code ?
                            What would the output be with the exact same code but using a while statement as opposed to
                            a do -while?
                            A : The do while loop only outputs a single “*” on the other hand the while loop doesn’t output
                any because the value is already greater then N. The while loop will check the condition before executing the program and the do while
                will execute the program then check the condition after
                Explain how do we combine multiple Boolean values? 
                Write an if statement that outputs “Let’s 
                go outside!” when both Boolean values are false.
 A: You can also combine true/false values by 
                using the Boolean operators, which take true/false values as operands and compute new 
                true/false values
 2. Identify and briefly describe 3 types of control structures that we can use to order the statements in our programs?
                The three basic types of control structures are sequential, selection and iteration. They can be combined in any way to solve a specified problem.
                Sequential is the default control structure, statements are executed line by line in the order in which they appear. The selection structure is 
                used to test a condition. A sequence of statements is executed depending on whether or not the condition it true or false. This means the program 
                chooses between two or more alternative paths. Condition refers to any expression or value that returns a Boolean value, meaning true or false.
                The three main types of selection statements are "if," "if/else" and "switch" statements. The most basic and common is the "if" statement. The "if" 
                and "if/else" statements can be nested. Switch statements are ideally used when there are multiple cases to choose from.
                The iteration or repetition structure repeatedly executes a series of statements as long as the condition is true. The condition may be predefined 
                or open-ended. "While," "do/while" and "for" loop are the three types of iteration statements. A loop can either be event controlled or counter 
                controlled. An event-controlled loop executes a sequence of statements till and event occurs while a counter-controlled loop executes the statements a predetermined number of times.

                */
        }
    }
}
