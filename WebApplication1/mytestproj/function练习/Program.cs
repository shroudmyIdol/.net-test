using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool b = IsRun(2000);

            Console.WriteLine(b);

            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            GetMaxMinSumAvg(nums, out int max,out int min, out int sum, out int avg);

            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
            Console.WriteLine(avg);

            Console.ReadKey();
        }

        public static bool IsRun(int year)
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);

        }

        /// <summary>
        /// 计算一个数组的最大值、最小值、总和、平均值
        /// </summary>
        /// <param name="nums">要求得的数组</param>
        /// <returns>多余返回的最大值</returns>
        /// <returns>多余返回的最小值</returns>
        /// <returns>多余返回的总和</returns>
        /// <returns>多余返回的平均值</returns>
        public static void GetMaxMinSumAvg(int[] nums, out int max, out int min, out int sum, out int avg)
        {
            max = nums[0];
            min = nums[0];
            sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }

                if (nums[i] < min)
                {
                    min = nums[i];
                }

                sum += nums[i];
            }

            avg = sum / nums.Length;
        }
    }
}
