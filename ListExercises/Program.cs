using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Lists!");
            List<int> intList = new List<int> { 75, 929, 3, 7, 69, 74, 674, 6, 80, 7 };
            int[] randomNumbers = new int[] { 1, 1, 2, 3, 5, 8 };
            List<int> convertedList = randomNumbers.ToList();
            Console.WriteLine(EvenSum(convertedList));
            List<string> stringList = new List<string> { "apple", "orange", "five", "hello", "Nala", "Kirby", "Tucker", "Bob", "Alyse", "Alex" };
            Console.WriteLine(PrintWords(stringList));
        }

        static int EvenSum(List<int> thisList)
        {
            int listSum = 0;
            foreach (int i in thisList)
            {
                if (i % 2 == 0)
                {
                    listSum += i;
                }
            }
            return listSum;
        }

        static bool PrintWords(List<string> thisList)
        {
            Console.WriteLine("Enter a length for the word Search: ");
            string input = Console.ReadLine();
            int length = int.Parse(input);
            foreach (string i in thisList)
            {
                if (i.Length == length)
                {
                    Console.WriteLine(i);
                }
            }
            return true;
        }

    }
}
