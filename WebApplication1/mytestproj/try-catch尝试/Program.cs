using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch尝试
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 问题：让用户输入一个数字并返回两倍的值给用户，但当用户输入的不是数字时，则返回错误"当前输入的数字有误"
            int number = 0;

            bool flag = true;

            // 提示用户输入一个数字
            Console.WriteLine("请输入一个数字");


            // 由于用户可能输入一个非数字的内容，导致转换类型失败，故用try-catch处理异常
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("当前输入的数字有误,无法转换");
                flag = false;
            }

            if (flag)
            {
                Console.WriteLine(number * 2);
            }

            Console.ReadKey();
        }
    }
}
