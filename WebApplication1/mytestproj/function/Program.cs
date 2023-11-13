using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function
{
    class Program
    {
        public static int _number = 10;
        static void Main(string[] args)
        {
            int max = GetMax(10, 20);
            Console.WriteLine(max);
            Console.ReadKey();
        }

        //计算两个整数之间的最大值


        /// <summary>
        /// 计算两个整数之间的最大值并且将最大值返回
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <returns>两个数之间的最大值</returns>
        public static int GetMax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }
    }
}
