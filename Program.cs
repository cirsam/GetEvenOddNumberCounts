using System;
using System.Linq;

namespace TestEvenOdd
{
    class Program
    {
        /*Count  all the even numbers
         * and all the odd numbers
         * from a list of numbers
         */

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] results = OddEven(numbers);

            //Reverse a string
            string str = "my name is samuel";

            string str_parts = String.Join(" ", str.Split(' ').Select(x => new String(x.Reverse().ToArray())));


            Console.WriteLine(str_parts);


            Console.WriteLine("Count of even numbers = {0} and Count of odd numbers = {1}", results[0], results[1]);
        }

        static int[] OddEven(int[] numbers)
        {
            int count_even = 0;
            int count_odd = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0) count_even++; count_odd++;
            }

            return new int[] { count_even, count_odd };
        }


    }

}
