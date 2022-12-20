using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParenthesis
{
    public  class Program
    {
        public static  bool IsValid(string s)
        {   
            Stack<char> stack = new Stack<char>();
            foreach (var item in s)
            {
                if (item == '(')
                    stack.Push(')');
                else if (item == '{')
                    stack.Push('}');
                else if (item == '[')
                    stack.Push(']');
                else if(stack.Count == 0 || stack.Pop() != item)
                {
                    return false;
                }

               
            }
            return stack.Count == 0;

        }
        static void Main(string[] args)
        {
            String s = "([{}])";
            Console.WriteLine(IsValid(s));
            Console.ReadLine();
        }
    }
}
