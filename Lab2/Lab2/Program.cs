using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1; //Declare the first number to add.
            int number2; //Declare the second number to add.
            int product; //Declare the product of number1 and number2.

            Console.WriteLine("Enter first integer:"); //Prompt the user.
            //read the first number from the user.
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second integer:"); //Prompt the user.
            //read the second number from the user.
            number2 = Convert.ToInt32(Console.ReadLine());

            product = number1 * number2; //Find the product
            Console.WriteLine("Product is {0}", product); //display the product.

            Console.WriteLine("{0}\n{1}", "Welcome to", "C# Programming!");

            Console.WriteLine("{0}  {1}", "Hello World!", "From Ryan Kazubski");

            /* 
             A.)The main method is where the program starts executing.

             B.)An integer exists inside the computer as a true binary value. A floating-point number, however, cannot exist in a computer that uses binary (1s and 0s).
              So, the floating-point number is faked. Using the same 32 bits

             C.)void is an example of a method

             D.)get and set accessors.

             E.)A class is a template for objects. A class defines object properties including a valid range of values, and a default value.
                An object has a state in which all of its properties have values that you either explicitly define or that are defined by default settings.
                Theoretically there is no limit to how many instances you can create, but it does rely on memory and it is possible to run out of that.
             */
        }
    }
}
