using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new int[10];

            // 声明数组的方式
            int[] numsTwo = { 1, 2, 3, 4, 5, 6 };


            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = i;
            //}

            //for (int i = 0; i < nums.Length; i++)
            //{

            //    Console.WriteLine(nums[i]);
            //}


            // 练习： 从一个整数数组里面取出最大的整数，最小的整数，总和，平均值
            // 声明一个int类型的数组 并且随意的赋初值
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int max = nums[0];
            int min = nums[0];
            int sum = 0;
            //循环数组并比较每个元素
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

            //练习：将一个字符串数组的元素的顺序进行反转。

            string[] names = { "我", "是", "好人" };

            for (int i = 0; i < names.Length / 2; i++)
            {
                string temp = names[i];
                names[i] = names[names.Length - 1 - i];
                names[names.Length - 1 - i] = temp;
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i] + "\t");
            }

            Console.ReadKey();
        }
    }
}
