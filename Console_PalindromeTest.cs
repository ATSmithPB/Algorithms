using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a word, and I will tell you if it is a Palindrome.");
            
            string str = Console.Readline();
            int strLen = str.Length;
            int strHalfLen;
            bool isPal = true;
            
            if (strLen % 2 == 0){
                strHalfLen = strLen/2;
            }
            else
            {
                strHalfLen = (strLen/2) + 1;
            }
            
            for (int i = 0; i < strHalfLen; i++)
            {
                if (str[i] != str[strLen-i])
                {
                    Console.WireLine($"Sorry, {str} is not a Palindrome.");
                    break;
                }
            }
              Console.WriteLine($"Wohoo! {str} is indeed a Palindrome");
        }
    }
}
 