using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveZeros
{
    internal class Program
    {
        public static void moveZeroes(int[] nums)
        {
            int count = 0;
            LinkedList<int> list = new LinkedList<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                    list.AddLast(nums[i]);
                else
                    count++;
            }
             
            for (int i = 0; i < nums.Length-count; i++)
            {
                nums[i] = list.ElementAt(i);

            }
           for (int i = nums.Length - count; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
            foreach(int num in nums)
            {
                Console.WriteLine(num.ToString()); 
            }

        }
        public static void moveZeroes2(int[] nums)
        {
            int left = 0;
            foreach(int num in nums)
            {
                if(num != 0)
                {
                    nums[left++] = num;
                }
            }
            while (left < nums.Length)
            {
                nums[left++] = 0;
            }
            foreach (int num in nums)
            {
                Console.WriteLine(num.ToString());
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 0, 3, 12 };
            moveZeroes2(arr);
            Console.ReadLine();
        }
    }
}
