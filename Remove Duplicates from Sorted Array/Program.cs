using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicates_from_Sorted_Array
{
    public  class Program
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int count = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(!list.Contains(nums[i]))
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
        public static int RemoveDuplicates2(int[] nums)
        {
            int picker = 0;
            for (int i = 1; i < nums.Length; i++) 
            if (nums[i] != nums[picker]) 
            nums[++picker] = nums[i];
            return nums.Length == 0 ? 0 : picker + 1;
        }
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0,0,1,1,2,2,3,3,3 };
            Console.WriteLine(RemoveDuplicates2(nums));
            
            Console.ReadLine();
        }
    }
}
