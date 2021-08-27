/* CSC205 Week 04 Programming Assignment, Problem #02
 * Instructor: Dr. Guangyan Li
 * Team Members: Ellyse Mooney, Shaira Lacour, Ja'vonn Liner
 * Purpose of Program: This program consists of several recursive methods.
 */
using System;

namespace Recurse
{
    class Program
    {
        static void Main(string[] args)
        {
            String book = "Think Sharp";
            Console.WriteLine(First(book));
            Console.WriteLine(Rest(book));
            Console.WriteLine(Length(book));

            Console.WriteLine(); //blank lines inserted for readbility

            WriteString(book);
            Console.WriteLine();

            WriteBackward(book);
            Console.WriteLine(); 

            Console.WriteLine(ReverseString(book));
            Console.ReadKey();
        }
        //First() method returns the first character of the given string.
        public static char First(string s)
        {
            return s[0];
        }

        /*Rest() method returns a new string that contains all but the 
         * first letter of the given string. */
        public static string Rest(string s)
        {
            return s.Substring(1);
        }

        //Length() returns the length of the given string.
        public static int Length(string s)
        {
            return s.Length;
        }

        /* Write a method called WriteString that takes a string as
         * a parameter and prints the letters of the string, one on each line. */
        public static void WriteString(string s)
        {
            if (Length(s) > 0)
            {
                Console.WriteLine(First(s));
                WriteString(Rest(s));
            }
        }

        /* Write a WriteBackward() method that prints the string backward, one character
         * per line. */
        public static void WriteBackward(string s)
        {
            if (Length(s) > 1)
            {
                WriteBackward(Rest(s));
            }
            Console.WriteLine(First(s));
        }
        /* Write a method called ReverseString that takes a string as a parameter and
         * that returns a new string as a return value. The new string should contain the
         * same letters as the parameter, but in reverse order.*/
        public static String ReverseString(string s)
        {
            if (Length(s) == 1)
            {
                return s;
            }
            else
            {
                String reversed = ReverseString(Rest(s)) + First(s);
                return reversed;
            }
        }
    }
}
