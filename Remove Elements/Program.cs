using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Elements
{
    public class Program
    {
        public static  int RemoveElement(int[] nums, int val)
        {
            int count = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                    list.Add(nums[i]);
            }


            int n = list.Count;
            for (int i = 0; i < nums.Length; i++)
            {

                // Console.WriteLine("list count" + list.Count);
                if (n > 0)
                {
                    //  Console.WriteLine("dsfwf" + list[0]);
                    nums[i] = list[i];
                    n--;
                    count++;

                }
                else
                {
                    nums[i] = 0;
                }
            }
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }

            return count;
        }
        public static int RemoveElement2(int[] nums, int val)
        {
            int m = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] != val)
                {
                    nums[m] = nums[i];
                    m++;
                }
            }
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
            return m;
        }


        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 2, 2, 3 };
            Console.WriteLine(RemoveElement2(nums,3));
            Console.ReadLine();
        }
    }
}
