using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_to_integer
{
    public  class Program
    {
        public static int RomanToInt(string s)
        {
            List<char> symbol = new List<char> { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            List<int> value = new List<int> { 1, 5, 10, 50, 100, 500, 1000 };
            int sum = 0;
            for (int i = 0; i < s.Length-1; i++)
            {
                if (symbol.Contains(s[i]))
                {
                    int curr = value[symbol.IndexOf(s[i])];
                    int next = value[symbol.IndexOf(s[i + 1])];
                    if (next > curr)
                   sum -= curr;
                   else
                   sum += curr;
                }
            }

            return sum +value[symbol.IndexOf(s[s.Length-1])];

        }
        static void Main(string[] args)
        {
            string str = "MCMXCIV";
            Console.WriteLine(RomanToInt(str));
            Console.ReadLine(); 
        }
    }
}
