using System;

namespace ArrayExercises
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Arrays!");
            int[] randomNumbers = new int[] { 1, 1, 2, 3, 5, 8 };
            foreach (int i in randomNumbers)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    
                }
            }
        }
    }
}
