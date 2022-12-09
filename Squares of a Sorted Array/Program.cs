using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares_of_a_Sorted_Array
{
    internal class Program
    {
        public static int[] SortedSquares(int[] nums)
        {
            List<int> negative = new List<int>();
            List<int> positive = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= 0)
                {
                    negative.Add(nums[i] * nums[i]);
                }
                else
                {
                    positive.Add(nums[i] * nums[i]);
                }

            }
            int[] arr = new int[negative.Count + positive.Count];
            int j = negative.Count-1;
            int k = 0;
            int a = 0;
            while (j >= 0 && k < positive.Count)
            {
                if (negative[j] < positive[k])
                {
                    arr[a++] = negative[j--];
                }
                else
                {
                    arr[a++] = positive[k++];
                }
            }

            while (j >= 0)
            {
                arr[a++] = negative[j--];    
            }
            while(k < positive.Count)
            {
                arr[a++]=positive[k++];
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] arr = { -4, -1, 0, 3, 10 };
           int [] result = SortedSquares(arr);
            foreach(int res in result)
            {
                Console.WriteLine(res.ToString());
            }
            Console.ReadLine();
        }

    }
    
   


}
