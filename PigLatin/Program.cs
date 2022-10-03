using System;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a word or sentence to translate to pig latin");
            string str = Console.ReadLine();
            string reverse = "";
            int length = str.Length - 1;

            while (length >= 0)
            {
                reverse += str[length];
                length--;
            }

            Console.WriteLine(reverse);
        }
    }
}