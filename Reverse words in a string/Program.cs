using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_words_in_a_string
{
    internal class Program

    {
        public static  void  ReverseWords(string s)
        {
           string[] str = s.Split(' ');
         
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                string subString = "";
                for (int j = str[i].Length - 1; j >=0; j--)
                {
                    subString += str[i][j];
                }

                result =result+subString+ " ";
                result.Trim();
            }
            Console.WriteLine();
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            ReverseWords("Hii I am Chetan");
            Console.ReadLine();
        }
    }
}
