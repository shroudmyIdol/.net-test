using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for循环练习
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 找出100-999间的水仙花数
            // 水仙花数指的是 百位的立方+十位的立方+个位的立方 = 当前这个数

            #region
            //for (int i = 100; i <= 999; i++) {
            //    int hundreds = i / 100;
            //    int ten = i % 100 / 10;
            //    int one = i % 10;
            //    if (hundreds * hundreds * hundreds + ten * ten * ten + one * one * one == i) {
            //        Console.WriteLine("{0}是一个水仙花数", i);
            //    }
            //}
            #endregion

            //99乘法表
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t", i, j, i * j);
                }
                Console.WriteLine();
            };


            Console.ReadKey();
        }
    }
}
