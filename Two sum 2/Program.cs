using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_sum_2
{
    internal class Program
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            var list = new ArrayList();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        list.Add(i);
                        list.Add(j);
                        break;
                    }
                }
            }

            return (int[])list.ToArray(typeof(int));

        }
        public static int[] TwoSum2(int[] numbers, int target)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (result.ContainsKey(numbers[i]))
                {
                    return new int[] { result[numbers[i]],i+1 }; 
                }
                else if (!result.ContainsKey(target - numbers[i])){
                    result.Add(target-numbers[i], i+1);  
                }
            }

           /* for (int i = 0; i < numbers.Length; i++)
            {
                if (result.ContainsKey(numbers[i]) && i != result[numbers[i]])
                {
                    return new int[] { i+1, result[numbers[i]]+1};
                }
            }*/
            return new int[] {};
        }

        static void Main(string[] args)
        {
            int[] arr = {2,7,11,15};
            int [] result=TwoSum2(arr, 9);
            foreach (int i in result)
            {
                Console.WriteLine(i.ToString());
            }
            Console.ReadLine();
        }
    }
}
