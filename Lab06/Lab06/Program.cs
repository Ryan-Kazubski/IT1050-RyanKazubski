using System;

namespace Lab06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * A one-dimensional array p contains four elements.  The array access expressions to access each of the elements in p are 0, 1,2 and 3.
             * 
             */

            int[] array = new int[12];

            Console.WriteLine("{0}{1,15}", "Index", "Month");
            
                String[] month = new string[12];
                month[0] = "January";
                month[1] = "Febraury";
                month[2] = "March";
                month[3] = "April";
                month[4] = "May";
                month[5] = "June";
                month[6] = "July";
                month[7] = "August";
                month[8] = "September";
                month[9] = "October";
                month[10] = "November";
                month[11] = "December";
            
            for (int a = 0; a < month.Length; ++a)
            {
                Console.WriteLine(a + "\t\t" + month[a]) ;
            }

            Random random = new Random();
            int[] randomNumber;

            foreach (int i in randomNumber)
            {
                randomNumber = random.Next(0, 1000);
                Console.WriteLine(i);
            }

            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            int i = 0;
            foreach (string b in names)
            {
                Console.WriteLine("{0}", names[b]);
                 b++;
            }


        }
    }
}
