using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Insert_Position
{
    internal class Program
    {
        public static int SearchInsert(int[] nums, int target)
        {


            int left = 0;
            int right = nums.Length - 1;
            int index = 0;

            while (left <= right)
            {
                int mid = (right + left) / 2;

                if (nums[mid] > target)
                {

                    right = mid - 1;
                    index = right+1;

                }
                else if (nums[mid] < target)
                {

                    left = mid + 1;
                    index=left; 
                }
                else
                {
                    if (nums[mid] == target)
                        return mid;
                    
                        
                }
                
                    



            }


            return index;
        }
        static void Main(string[] args)
        {
            int[] arr = { -1, 0, 3, 5, 9, 12 };
            Console.WriteLine(SearchInsert(arr, 15));
            Console.ReadLine();

        }

    }


   
    
}
