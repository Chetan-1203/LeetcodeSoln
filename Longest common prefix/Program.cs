using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_common_prefix
{
    public  class Program
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null) return "";
            string pre = strs[0];
            for (int i = 1; i < strs.Length; i++)
                while (strs[i].IndexOf(pre) != 0)
                    pre = pre.Substring(0, pre.Length - 1);
            return pre;
        }
        static void Main(string[] args)
        {
            string[] strs = new string[] { "flower", "flow", "flight" };
            Console.WriteLine(LongestCommonPrefix(strs));
            Console.ReadLine(); 
        }
    }
}
