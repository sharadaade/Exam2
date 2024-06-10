using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    internal class Q1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string : ");
            string str = Console.ReadLine();

            //char[] c = str.ToCharArray();

            int vowel = 0;
            int consonant = 0;

            // Convert the string to lowercase
            str = str.ToLower();

            foreach (char character in str)
            {
                // Check if character is a vowel
                if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                {
                    vowel++;
                }
                // Check if character is a letter consonant
                else
                {
                    consonant++;
                }
            }

            Console.WriteLine("vovel " + vowel);
            Console.WriteLine("consonant" + consonant);

        }
    }
}
