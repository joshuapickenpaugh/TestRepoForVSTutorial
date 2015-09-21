//Joshua Pickenpaugh, September 21st, 2015
//IN2017 Adv.C# Module 05 excersise.
//Added this line for testing GITHUB.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module05Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration and object instantiation:
            int num1 = 1;
            int num2 = 2;
            int total = 0;

            Random newRandom = new Random();

            //Method call and display:
            total = Add(num1, num2);
            Console.WriteLine("{0} + {1} = {2}", num1, num2, total);
            total = ClearBySubtraction(total, total);
            Console.WriteLine("Clearing the 'total' variable: " + total);

            //Random number call, range, and display:
            Console.WriteLine("Printing a random number between 0 and 10: " + newRandom.Next(0, 10)); 

            //Overloaded examples:
            Console.WriteLine("Calling first overloaded method: " + Mysterious(35, 65));
            Console.WriteLine("Calling second overloaded method: " + Mysterious(75.3, 74.2));

            //Recursion example:
            Console.WriteLine("Recursion: " + Recursion(3));

            //Declare an array, initailize, and iterate with a 'for' loop:
            Console.WriteLine("Array and 'for' loop:");
            int[] myArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            //Using a 'foreach' to iterate through array:
            Console.WriteLine("Array and 'foreach' loop:");
            foreach (int thingy in myArray)
            {
                Console.WriteLine(thingy);
            }

            //Passing an array to a method:
            Console.WriteLine("Passing an array to a method:");
            DisplayArray(myArray);

            //Query an array using LINQ:
            Console.WriteLine("LINQ request and display via 'foreach' loop:");
                var linqRequest =
                    from a in myArray
                    where a > 5
                    select a;
            foreach (int thingy in linqRequest)
            {
                Console.WriteLine(thingy);
            }

            Console.ReadKey();
        }

        //User-defined method:
        public static int Add(int methNum1, int methNum2, int total = 0)
        {
            total = methNum1 + methNum2;
            return total;
        }

        public static int ClearBySubtraction(int methNum1, int methNum2, int total = 0)
        {
            total = methNum1 - methNum2;
            return total;
        }

        public static int Mysterious(int methNum1, int methNum2, int total = 0)
        {
            total = methNum1 + methNum1;
            return total;
        }

        public static double Mysterious(double methNum1, double methNum2, double total = 0)
        {
            total = methNum1 + methNum2;
            return total;
        }

        public static int Recursion(int methNum1)
        {
            if (methNum1 <= 0)
            {
                return 1;
            }
            else
            {
                return (methNum1 * Recursion(methNum1 - 1));
            }
        }

        public static void DisplayArray(int[] methArray)
        {
            foreach (int methThingy in methArray)
            {
                Console.WriteLine(methThingy);
            }
        }
    }
}
