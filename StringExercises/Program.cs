using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Strings!");
            string rhyme = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            string[] rhymeWords = rhyme.Split(" ");
            Console.WriteLine(string.Join(",", rhymeWords));

            string[] rhymeSentences = rhyme.Split(".");
            Console.WriteLine(string.Join(",", rhymeSentences));


        }
    }
}
