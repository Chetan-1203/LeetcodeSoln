using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_Array
{
    internal class Program
    {


        public static int  [] Rotate(int[] nums, int k)
        {
            int l = nums.Length;
            int[] arr = new int[l];
            int j = 0;
            for (int i = l - k; i < nums.Length; i++)
            { 
                arr[j]=nums[i];
                j++;

            }
            for (int i = 0; i < l-k; i++)
            {
                arr[j++]=nums[i];   

            }
            nums = arr;

            return nums;

            /*foreach (int i in arr)
            {
                Console.Write(i.ToString()+ " ");
            }*/
        }
        static void Main(string[] args)
        {
            int[] arr = { 7, 1, 2, 3, 4, 5, 6 };
            int [] result =Rotate(arr, 3);
            foreach (var item in result)
            {
                Console.Write(item.ToString());
            }
            Console.ReadLine();

        }
    }
}
