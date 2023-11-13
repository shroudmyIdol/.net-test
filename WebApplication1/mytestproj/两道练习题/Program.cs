using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 两道练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 练习，编程实现计算几天（如46天）是几周零几天
            int days = 46;
            int weeks = days / 7;
            int day = days % 7;

            Console.WriteLine("{0}天是{1}周零{2}天", days, weeks, day);

            Console.ReadKey();
        }
    }
}
