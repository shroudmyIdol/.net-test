using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 交换变量
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b = 20;

            a = a - b; //a= 10, b= 20
            b = a + b; //a= 10, b= 30
            a = b - a; //a= 20, b= 30

            Console.WriteLine("a的值为{0}，b的值为{1}", a, b);
            Console.ReadKey();
        }
    }
}
