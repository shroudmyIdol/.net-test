using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace params参数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test("张三", 98, 95, 96);
            Console.ReadKey();
        }

        /// <summary>
        /// 返回一个学生的总成绩
        /// </summary>
        /// <param name="name"></param>
        /// <param name="score"></param>
        /// <returns></returns>
        public static void Test(string name, params int[] score)
        {
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }

            Console.WriteLine("{0}这次的总成绩是{1}", name, sum);
        }
    }
}
