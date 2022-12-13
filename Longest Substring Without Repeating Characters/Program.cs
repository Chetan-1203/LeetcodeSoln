using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Substring_Without_Repeating_Characters
{
    public  class Program
    {
        
        public static int LengthOfLongestSubstring(string s)
        {
            string result = "";
            int length = 0;
            
            if(s.Length == 0)
            {
                return 0;   
            }

            if (s.Length == 1)
            {
                return 1;
            }

            foreach(char c in s)
            {
                var ch = c;

                if (result.Contains(ch))
                {
                   
                    result=result.Substring(result.IndexOf(ch)+1); 
                }
                result = result + c;
                length = Math.Max(length, result.Length);
            }
            return length;
        }
        static void Main(string[] args)
        {
            string a = "pwwkew";
            
            Console.WriteLine(LengthOfLongestSubstring(a));
            Console.ReadLine(); 
        }
    }
}
