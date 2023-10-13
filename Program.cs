using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_String_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            bool isPalindrome = str.SequenceEqual(str.Reverse());

            if (isPalindrome)
            {
                Console.WriteLine($"{str} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{str} is not a palindrome.");
            }
        }
    }
}
