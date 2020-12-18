using System;
using System.Collections.Generic;
using System.Text;

namespace Studio_Counting_Characters
{
    class CharacterCounter
    {
        public static void Counter()
        {
            //string sampleString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            Console.WriteLine("Enter a string: ");
            string stringInput = Console.ReadLine();
            char[] charactersInString = stringInput.ToCharArray();
            Dictionary<string, int> characterCounts = new Dictionary<string, int>();
            foreach (char i in charactersInString)
            {
                if (Char.IsLetter(i))
                {
                    string thisChar = Char.ToUpper(i) + "/" + Char.ToLower(i);
                    int thisCharCount = 0;
                    foreach (char c in charactersInString)
                    {
                        if (Char.ToLower(c) == Char.ToLower(i))
                        {
                            thisCharCount += 1;
                        }
                    }
                    if (!characterCounts.ContainsKey(thisChar))
                    {
                        characterCounts.Add(thisChar, thisCharCount);
                    }
                }
            }
            foreach (KeyValuePair<string, int> printChar in characterCounts)
            {
                Console.WriteLine(printChar.Key + ": " + printChar.Value);
            }
        }

    }
}
