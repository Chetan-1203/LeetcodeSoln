using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_One
{
    internal class Program
    {
        public  static int[] PlusOne(int[] digits)
        {  
            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }

                digits[i]=0;
            }

            int[] result = new int[n+1];
            result[0] = 1;
            return result;

        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 9,9 };
            
            int[] ans = PlusOne(arr);

            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
           
        }
    }
}
