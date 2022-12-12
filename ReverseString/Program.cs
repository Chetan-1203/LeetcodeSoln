using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class Program
    {
        public static void ReverseString(char[] s)
        {
            int j = s.Length - 1; ;
            for (int i = 0; i < s.Length/2; i++)
            {
                char temp = s[i];
                s[i] = s[j];
                s[j] = temp;
                j--;
            }
            foreach(char c in s)
            {
                Console.WriteLine(c.ToString());
            }
        }

        public static void ReverseString2(char[] s)
        {
           Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                stack.Push(s[i]);
            }
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = stack.Pop();
            }
            foreach (char c in s)
            {
                Console.WriteLine(c.ToString());
            }
        }
        static void Main(string[] args)
        {
            char[] c = { 'h', 'e', 'l', 'l', '0' };
            ReverseString2(c);
            Console.ReadLine();
        }
    }
}
