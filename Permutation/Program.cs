using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    public  class Program
    {
        public static bool CheckInclusion(string s1, string s2)
        {
            int len1 = s1.Length, len2 = s2.Length;
            if (len1 > len2) return false;

            int[] count = new int[26];
            for (int i = 0; i < len1; i++)
            {
                count[s1[i] - 'a']++;
                count[s2[i] - 'a']--;
            }
            if (allZero(count)) return true;

            for (int i = len1; i < len2; i++)
            {
                count[s2[i] - 'a']--;
                if (i - len1 >= 0) count[s2[i - len1] - 'a']++;
                if (allZero(count)) return true;
            }

            return false;
        }
        private static bool allZero(int[] count)
        {
            for (int i = 0; i < 26; i++)
            {
                if (count[i] != 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            string a = "eidbaooo";
            Console.WriteLine(CheckInclusion("ab",a));
            Console.ReadLine();
        }
    }
}
